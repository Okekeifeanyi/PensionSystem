//using Microsoft.OpenApi.Models;

//namespace PensionNLPC.Configurations
//{
//    public class SwaggerExtension
//    {
//        public static void AddSwagger(this IServiceCollection services)
//        {
//            services.AddSwaggerGen(config =>
//            {
//                config.SwaggerDoc("v1", new OpenApiInfo
//                {
//                    Title = "NLPC PENSION",
//                    Version = "v1",
//                    Description = "Pension Software "
//                });
//                config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//                {
//                    In = ParameterLocation.Header,
//                    Description = "Insert Token",
//                    Name = "Authorization",
//                    Type = SecuritySchemeType.Http,
//                    BearerFormat = "Jwt",
//                    Scheme = "Bearer"
//                });
//                config.AddSecurityRequirement(new OpenApiSecurityRequirement
//                {
//                    {
//                        new OpenApiSecurityScheme
//                        {
//                            Reference = new OpenApiReference
//                            {
//                                Type = ReferenceType.SecurityScheme,
//                                Id = "Bearer"
//                            }
//                        },
//                        new string[] {}
//                    }
//                });

//            });

//        }

//    }
//}
