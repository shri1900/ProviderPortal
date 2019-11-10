namespace Portal.API.Models
{
    public class RolePermission
    {
        public int RolePermissionId { get; set; }
        public Role Role { get; internal set; }
        public int RoleRefId { get; internal set; }
        public bool HomePage { get; set; }
        public bool Page1 { get; set; }
        public bool Page2 { get; set; }
        public bool Page3 { get; set; }
        public bool Page4 { get; set; }
        public bool Page5 { get; set; }
        public bool Page6 { get; set; }
        public bool Page7 { get; set; }
        public bool Page8 { get; set; }
        public bool Page9 { get; set; }

    }
}