namespace SimpleAPI.Builders
{
    public static class SwaggerExt
    {

        public static void UseSwaggerExt(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

        }
    }
}
