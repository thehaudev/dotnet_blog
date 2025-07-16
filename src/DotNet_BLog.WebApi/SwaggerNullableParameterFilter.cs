using AutoMapper.Internal;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace DotNet_BLog.WebApi
{
    public class SwaggerNullableParameterFilter : IParameterFilter
    {
        public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
        {
            if (!parameter.Schema.Nullable && (context.ApiParameterDescription.Type.IsNullableType() || !context.ApiParameterDescription.Type.IsValueType))
            {
                parameter.Schema.Nullable = true;
            }
        }
    }
}
