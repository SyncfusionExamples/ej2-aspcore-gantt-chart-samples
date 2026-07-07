using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace CustomAdaptor.client.Pages
{
    public class IndexModel : PageModel
    {
        
        public List<object> ToolbarItems { get; set; } = new();
        public List<ResourceModel> Resources { get; set; } = new();

        public void OnGet()
        {
            
            ToolbarItems.Add("Add");
            ToolbarItems.Add("Edit");
            ToolbarItems.Add("Update");
            ToolbarItems.Add("Delete");
            ToolbarItems.Add("Cancel");
            ToolbarItems.Add("ExpandAll");
            ToolbarItems.Add("CollapseAll");

            Resources = new List<ResourceModel>
            {
                new ResourceModel { resourceId = 1, resourceName = "Martin Tamer" },
                new ResourceModel { resourceId = 2, resourceName = "Rose Fuller" },
                new ResourceModel { resourceId = 3, resourceName = "Margaret Buchanan" },
                new ResourceModel { resourceId = 4, resourceName = "Fuller King" },
                new ResourceModel { resourceId = 5, resourceName = "Davolio Fuller" },
                new ResourceModel { resourceId = 6, resourceName = "Van Jack" },
                new ResourceModel { resourceId = 7, resourceName = "Fuller Buchanan" },
                new ResourceModel { resourceId = 8, resourceName = "Jack Davolio" },
                new ResourceModel { resourceId = 9, resourceName = "Tamer Vinet" },
                new ResourceModel { resourceId = 10, resourceName = "Vinet Fuller" },
                new ResourceModel { resourceId = 11, resourceName = "Bergs Anton" },
                new ResourceModel { resourceId = 12, resourceName = "Construction Supervisor" }
            };
        }
    }

    public class ResourceModel
    {
        public int resourceId { get; set; }
        public string resourceName { get; set; }
        public int? resourceUnit { get; set; }
        public string resourceGroup { get; set; }
    }
}