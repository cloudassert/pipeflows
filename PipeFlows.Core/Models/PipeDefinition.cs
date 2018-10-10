using System;
using System.Collections.Generic;

namespace PipeFlows.Core.Models
{
    public class Tenant {
        public Guid TenantId {get;set;}
        public string OwnerUserId {get;set;}

        public string TenantName {get;set;}

        public DateTimeOffset Created {get;set;}
        public DateTimeOffset? Updated {get;set;}
    }

    public class ResourceGroup {
        public Guid TenantId {get;set;}
        public string Name {get;set;}
        public string CreatedByUserId {get;set;}
        public DateTimeOffset Created {get;set;}
        public DateTimeOffset? Updated {get;set;}
    }

    public class PipeDefinition
    {
        public Guid TenantId {get;set;}
        public string ResourceGroupName {get;set;}
        public string Name {get;set;}
        public PipeDefinitionType Type {get;set;}
        public List<StageDefinition> Stages {get;set;}

        public string CreatedByUserId {get;set;}

        public DateTimeOffset Created {get;set;}
        public DateTimeOffset? Updated {get;set;}
    }

    public class StageDefinition {
        public string PipeDefinitionName {get;set;}
        public string Name {get;set;}
        public int Order {get;set;}
        public string[] AllowedStates {get;set;}

        ///
        // Subset of Allowed States that marks completion of the Stage and makes the flow move to next stage
        ///
        public string[] CompletionStates {get;set;}

        ///
        // Subset of Allowed States that marks error in the Stage
        ///
        public string[] ErrorStates {get;set;}
    }

    public enum PipeDefinitionType {
        SimpleSequence = 0,
        VSTSTrackableItem = 5000
    }
}