namespace HSPA_TEST.BLL.DTOs
{
<<<<<<< HEAD
    public class PropertyDetailDto
    {
=======
    public class PropertyDetailDto : PropertyListDto
    {
        public int CarpetArea { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public int FloorNo { get; set; }
        public int TotalFloors { get; set; }
        public string MainEntrance { get; set; }
        public int Security { get; set; }
        public bool Gated { get; set; }
        public int Maintenance { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }
>>>>>>> a9bc5bd5a40d2ed2b39611e4e3d3987439611093
    }
}
