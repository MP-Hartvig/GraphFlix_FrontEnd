namespace GraphFlix_FrontEnd.Models
{
	public class MovieModel
	{
		public string Id { get; }
		public string Title { get; set; }
		public DateOnly ReleaseDate { get; set; }
		public List<GenreModel> Genres { get; set; }
	}
}
