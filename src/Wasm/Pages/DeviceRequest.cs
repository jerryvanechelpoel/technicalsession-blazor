using MatBlazor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IR.DeviceRequestApp.Wasm.Pages
{
    public partial class DeviceRequest
    {
        public Request Request { get; set; }
        public Dictionary<int, string> Devices { get; set; }
        public string ConfirmationMessage { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            Request = new Request();
            Devices = new Dictionary<int, string>
            {
                { 1, "Tablet" },
                { 2, "Laptop" },
                { 3, "PC" },
                { 4, "Smartphone" }
            };
        }

        protected async Task SubmitRequestAsync()
        {
            await MatDialogService.AlertAsync("Thank you, we're getting started with your request!");
        }
    }
}