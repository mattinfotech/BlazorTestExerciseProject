using BlazorTestProject.Models;

namespace BlazorTestProject.Components.Pages
{
    public partial class Home
    {
        private UserModel User { get; set; } = new();
        private UserModel? SubmittedUser { get; set; }
        private bool IsSubmitting { get; set; }
        private string? StatusMessage { get; set; }

        private async Task HandleSubmit(UserModel submittedUser)
        {
            IsSubmitting = true;
            StatusMessage = null;

            try
            {
                await Task.Delay(300);

                SubmittedUser = new UserModel
                {
                    Name = submittedUser.Name?.Trim(),
                    Address = submittedUser.Address?.Trim(),
                    Age = submittedUser.Age,
                    Email = submittedUser.Email?.Trim().ToLowerInvariant()
                };

                StatusMessage = $"User '{SubmittedUser.Name}' was submitted successfully.";
                User = new UserModel();
            }
            finally
            {
                IsSubmitting = false;
            }
        }
    }
}
