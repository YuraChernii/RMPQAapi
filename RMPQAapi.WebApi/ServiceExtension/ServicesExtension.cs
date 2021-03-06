using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RMPQAapi.Data.Entities;
using RMPQAapi.Data.Infrastructure;
using RMPQAapi.Domain.Services.Implementation;
using RMPQAapi.Domain.Services.Interfaces;

namespace RMPQAapi.WebApi.ServiceExtension
{
    public static class ServicesExtension
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<BlobServiceClient>(provider =>
             //   new BlobServiceClient(configuration.GetSection("AzureBlobStorageOptions")
              //      .GetValue<string>("AccessKey")));
            //services.AddScoped<ICompressor, ImageCompressor>();
            //services.AddSingleton<IFirebaseService, FirebaseService>();
            //services.AddScoped<IPushNotificationService, PushNotificationService>();
            //services.AddScoped<IFileService, AzureBlobStorageService>();
            //services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            //services.AddScoped<ILoginService, LoginService>();
           // services.AddScoped<IBrandService, BrandService>();
            //services.AddScoped<IModelService, ModelService>();
            //services.AddScoped<IUserPreferencesService, UserPreferencesService>();
            //services.AddScoped<IChatService, ChatService>();
            //services.AddScoped<IJourneyService, JourneyService>();
            //services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IImageService, ImageService>();
            //services.AddScoped<IWebTokenGenerator, JsonWebTokenGenerator>();
            //services.AddScoped<ILocationService, LocationService>();
            //services.AddScoped<IRequestService, RequestService>();
            //services.AddScoped<ILocationTypeService, LocationTypeService>();
            //services.AddScoped<IJourneyUserService, JourneyUserService>();
            //services.AddScoped<IReceivedMessagesService, ReceivedMessagesService>();

            services.AddScoped<IRepository<Product>, Repository<Product>>();
            //services.AddScoped<IRepository<Data.Entities.Car>, Repository<Data.Entities.Car>>();
            //services.AddScoped<IRepository<UserPreferences>, Repository<UserPreferences>>();
            //services.AddScoped<IRepository<Brand>, Repository<Brand>>();
            //services.AddScoped<IRepository<Model>, Repository<Model>>();
            //services.AddScoped<IRepository<Chat>, Repository<Chat>>();
            //services.AddScoped<IRepository<FcmToken>, Repository<FcmToken>>();
            //services.AddScoped<IRepository<Message>, Repository<Message>>();
            //services.AddScoped<IRepository<Journey>, Repository<Journey>>();
            //services.AddScoped<IRepository<Invitation>, Repository<Invitation>>();
            //services.AddScoped<IRepository<Notification>, Repository<Notification>>();
            //services.AddScoped<IRepository<Location>, Repository<Location>>();
            //services.AddScoped<IRepository<LocationType>, Repository<LocationType>>();
            //services.AddScoped<IRepository<Request>, Repository<Request>>();
            //services.AddScoped<IRepository<Stop>, Repository<Stop>>();
            //services.AddScoped<IRepository<JourneyPoint>, Repository<JourneyPoint>>();
            //services.AddScoped<IRepository<JourneyUser>, Repository<JourneyUser>>();
            //services.AddScoped<IRepository<ReceivedMessages>, Repository<ReceivedMessages>>();
        }

        public static void InitializeConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<Jwt>(configuration.GetSection("Jwt"));
            //services.Configure<AzureBlobStorageOptions>(configuration.GetSection("AzureBlobStorageOptions"));
            //services.Configure<FirebaseOptions>(configuration.GetSection("FirebaseOptions"));
        }
    }
}
