using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace eShopSolution.AdminApp.Services
{
    public class UserApiClient : IUserApiClient
    {
        

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public UserApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.PostAsync("/api/users/authenticate", httpContent);
            var token = await response.Content.ReadAsStringAsync();
            return token;
        }



        public async Task<PagedResult<UserVm>> GetUsersPagings(GetUserPagingRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", request.BearerToken);// phương thức này là để lấy token vì muốn lấy  danh sách user thì phải đăng nhập vào admin

            var urlR = ($"/api/users/paging?pageIndex=" +
             $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}&bearerToken={request.BearerToken}");
            //var urlR = ($"/api/users/paging?pageIndex=" +
            // $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}");
            var response = await client.GetAsync(urlR);
            var body = await response.Content.ReadAsStringAsync();                  // đoạn này là check đầu ra 
            var users = JsonConvert.DeserializeObject<PagedResult<UserVm>>(body);// // đoạn này là check đầu ra 
            return users;
        }

        public async Task<bool> RegisterUser(RegisterRequest registerRequest)// phương thức này không cần phải lấy token vì đăng kí tài khoản thì không cần
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var json = JsonConvert.SerializeObject(registerRequest); // httpContent là body để chứa dữ liệu để post lên
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/api/users", httpContent);// đăng kí nên sử dụng PostAsync thay vì GetAsync
                                                                 // Post thì cần 1 body để chứa nên ta cần phải có 1 httpContent
            //var body = await response.Content.ReadAsStringAsync();
            //var users = JsonConvert.DeserializeObject<PagedResult<UserVm>>(body); // đoạn này là check đầu ra nhưng không cần thiết
            //return users;
            return response.IsSuccessStatusCode; // kiểm trả trạng thái đăng kí thành công chưa
        }
    }
}
