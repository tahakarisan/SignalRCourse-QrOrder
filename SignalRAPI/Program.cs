using Microsoft.EntityFrameworkCore;
using SignalRBusinessLayer.Abstract;
using SignalRBusinessLayer.Concrete;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.EntityFramework;
using System.Reflection;
using AutoMapper;
using SignalRAPI.Mapping;
using SignalR.EntityLayer.Entities;
using SignalRAPI.Hubs;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});

builder.Services.AddSignalR();

builder.Services.AddDbContext<SignalRContext>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();      

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDal, EfBookingDal>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();

builder.Services.AddScoped<IDiscountService, DiscountManager>();
builder.Services.AddScoped<IDiscountDal, EfDiscountDal>();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDal, EfProductDal>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();




builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();         // ✅ Swagger middleware  
    app.UseSwaggerUI();       // ✅ Swagger arayüzü  
}

app.UseCors("CorsPolicy");

app.MapHub<SignalRHub>("/signalRHub");

app.MapControllers();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
