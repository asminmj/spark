﻿using Coravel.Invocable;

namespace HealthyTipsBlog.Application.Jobs;

public class ExampleJob : IInvocable
{

    public ExampleJob()
    {
    }

    public Task Invoke()
    {
        Console.WriteLine("Do something in the background.");
        return Task.CompletedTask;
    }
}
