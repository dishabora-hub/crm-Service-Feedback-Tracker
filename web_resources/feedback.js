function checkRating(executionContext) {
    var formContext = executionContext.getFormContext();

    var rating = formContext.getAttribute("disha_rating").getValue();
    var comments = formContext.getAttribute("disha_comments");

    if (rating !== null && rating <= 2) {
        // Show alert
        formContext.ui.setFormNotification(
            "Low rating detected. Please provide comments.",
            "WARNING",
            "rating_alert"
        );

        // Make comments required
        comments.setRequiredLevel("required");
    } else {
        // Remove alert
        formContext.ui.clearFormNotification("rating_alert");

        // Make comments optional
        comments.setRequiredLevel("none");
    }
}
