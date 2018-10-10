using System;
using System.Collections.Generic;

namespace PipeFlows.Core.Models {

    public class PipeRun {
        public Guid PipeRunId {get;set;}
        public Guid TenantId {get;set;}
        public string ResourceGroupName {get;set;}
        public string PipeDefinitionName {get;set;}

        public string CreatedByUserId {get;set;}

        public DateTimeOffset Created {get;set;}
        public DateTimeOffset? Started {get;set;}
        public DateTimeOffset? Updated {get;set;}
        public DateTimeOffset? Completed {get;set;}

        public string CurrentStage {get;set;}

        public string CurrentStageState {get;set;}

        public List<PipeRunStage> PipeRunStages {get;set;}

    }

    public class PipeRunStage {
        public Guid PipeRunId {get;set;}
        public string StageName {get;set;}

        public Guid PreviousStageId {get;set;}

        public string CurrentState {get;set;}

        public StageExecutionStatus ExecutionStatus {get;set;}
        public DateTimeOffset Created {get;set;}
        public DateTimeOffset? Started {get;set;}
        public DateTimeOffset? Updated {get;set;}
        public DateTimeOffset? Completed {get;set;}

        public List<PipeRunStageStateTransitions> States {get;set;}
    }

    public class PipeRunStageStateTransitions {
        public Guid PipeRunId {get;set;}
        public string StageName {get;set;}
        public string State {get;set;}
        public string PreviousState {get;set;}
        public DateTimeOffset TransitionTimestamp {get;set;}
    }

     public enum StageExecutionStatus
    {
        Created = 0,

        Blocked  = 40,

        InProgress = 50,

        Completed = 100,

        Cancelled = 300,

        Error = 400,
    }
}