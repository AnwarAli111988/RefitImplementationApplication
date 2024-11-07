using Refit;

namespace RefitApplication
{
    public interface IDogApi
    {
        [Get("/breeds")]
        Task<ApiResponse<List<DogBreedResponse>>> GetBread();
    }
}
