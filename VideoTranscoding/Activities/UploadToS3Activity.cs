﻿using System.Threading.Tasks;
using Guflow.Worker;

namespace VideoTranscoding.Activities
{
    [ActivityDescription("1.0", DefaultHeartbeatTimeoutInSeconds = 100, DefaultScheduleToCloseTimeoutInSeconds = 50,
        DefaultScheduleToStartTimeoutInSeconds = 20, DefaultStartToCloseTimeoutInSeconds = 80,
        DefaultTaskListName = "sometask", DefaultTaskPriority = 10)]
    public class UploadToS3Activity : Activity
    {
        [ActivityMethod]
        public async Task<string> Execute(string input)
        {
            //simulate upload to s3
            await Task.Delay(10);
            return "done";
        }

        public class Input
        {
            public string FilePath;
        }
    }
}