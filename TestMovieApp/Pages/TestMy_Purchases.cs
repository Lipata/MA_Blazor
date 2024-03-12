using Bunit;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Pages;
using MovieApp.MovieAppData;

namespace TestMovieApp
{
	[Collection("MovieApp")]
	public class TestMy_Purchases
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			ctx.Services.AddScoped<IMovieAppDataService>(sp => new MockMovieAppDataService());
			var componentUnderTest = ctx.RenderComponent<My_Purchases>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
