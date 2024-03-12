using Bunit;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Pages;

namespace TestMovieApp
{
	[Collection("MovieApp")]
	public class TestMovie_Complex
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Movie_Complex>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
