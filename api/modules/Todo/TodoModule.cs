﻿using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Todo.Features.TodoItemCreation.v1;

namespace Todo;
public static class TodoModule
{
    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var todoGroup = app.MapGroup("todo").WithTags("todo");
            todoGroup.MapTodoItemCreationEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterTodoServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        return builder;
    }
    public static WebApplication UseTodoModule(this WebApplication app)
    {
        return app;
    }
}
