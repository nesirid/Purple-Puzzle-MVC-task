namespace AspMVCHomeTask.Models
{
    public class SliderImage : BaseEntity
    {
        public string ImageUrl { get; set; }
        public int Order { get; set; }
        public int SliderId { get; set; }
        public Slider Slider { get; set; }
    }
}
