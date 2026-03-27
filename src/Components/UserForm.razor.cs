using BlazorTestProject.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorTestProject.Components
{
    public partial class UserForm
    {
        [Parameter, EditorRequired]
        public UserModel Model { get; set; } = default!;

        [Parameter]
        public string SubmitButtonText { get; set; } = "Submit";

        [Parameter]
        public bool IsSubmitting { get; set; }

        [Parameter, EditorRequired]
        public EventCallback<UserModel> OnSubmit { get; set; }

        private async Task HandleValidSubmit()
        {
            await OnSubmit.InvokeAsync(Model);
        }
    }
}
