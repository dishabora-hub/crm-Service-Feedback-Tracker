using System;
using Microsoft.Xrm.Sdk;

public class CreateSupportTicket : IPlugin
{
    public void Execute(IServiceProvider serviceProvider)
    {
        IPluginExecutionContext context =
            (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

        
        IOrganizationServiceFactory factory =
            (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));

        IOrganizationService service =
            factory.CreateOrganizationService(context.UserId);

   
        if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
        {
        
            Entity feedback = (Entity)context.InputParameters["Target"];

          
            if (feedback.LogicalName != "disha_feedback")
                return;

            if (feedback.Contains("disha_rating"))
            {
               
                OptionSetValue rating = feedback.GetAttributeValue<OptionSetValue>("disha_rating");

             
                if (rating != null && rating.Value < 3)
                {
                    
                    Entity ticket = new Entity("disha_supportticket");

                 
                    ticket["disha_title"] = "Low Satisfaction Feedback";

              
                    if (feedback.Contains("disha_customer"))
                        ticket["disha_customer"] = feedback["disha_customer"];

              
                    ticket["disha_relatedfeedback"] = new EntityReference(
                        "disha_feedback",
                        feedback.Id
                    );
                    if (feedback.Contains("disha_customeremail"))
                        ticket["disha_customeremail"] = feedback["disha_customeremail"];
                   
                    if (feedback.Contains("disha_comments"))
                        ticket["disha_description"] = feedback["disha_comments"];

                    
             
                    if (rating.Value == 1)
                    {
                        ticket["disha_priority"] = new OptionSetValue(192350000); // Urgent
                    }
                    else if (rating.Value == 2)
                    {
                        ticket["disha_priority"] = new OptionSetValue(192350001); // Important
                    }

                    service.Create(ticket);
                }
            }
        }
    }
}
