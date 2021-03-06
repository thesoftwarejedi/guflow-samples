﻿using System.Threading.Tasks;
using Guflow.Worker;

namespace TaskListRouting.Activities
{
    [ActivityDescription("1.0", DefaultHeartbeatTimeoutInSeconds = 100, DefaultScheduleToCloseTimeoutInSeconds = 50,
        DefaultScheduleToStartTimeoutInSeconds = 20, DefaultStartToCloseTimeoutInSeconds = 80,
        DefaultTaskListName = "sometask", DefaultTaskPriority = 10)]
    public class DownloadActivity : Activity
    {

        [ActivityMethod]
        public async Task<Response> Execute(string input)
        {
            //simulate downloading of file
            await Task.Delay(10);
            return new Response() { DownloadedFile = "downloaded path", PollingQueue = PollingQueue.Download};
        }

        public class Response
        {
            public string DownloadedFile;
            public string PollingQueue;
        }

    }
}