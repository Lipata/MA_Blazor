using Bunit;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Pages;
using MovieApp.MovieAppData;

namespace TestMovieApp
{
	[Collection("MovieApp")]
	public class TestMovies
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbTabsModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbSelectModule),
				typeof(IgbDatePickerModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule));
			ctx.Services.AddScoped<IMovieAppDataService>(sp => new MockMovieAppDataService());
			var componentUnderTest = ctx.RenderComponent<Movies>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
