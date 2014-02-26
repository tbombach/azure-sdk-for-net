// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure.Scheduler.Models;

namespace Microsoft.WindowsAzure.Scheduler.Models
{
    /// <summary>
    /// The definition of a Windows Azure Scheduler job.
    /// </summary>
    public partial class Job
    {
        private JobAction _action;
        
        /// <summary>
        /// Action to invoke for the job.
        /// </summary>
        public JobAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Job identifier.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private JobRecurrence _recurrence;
        
        /// <summary>
        /// Recurrence schedule for the job.
        /// </summary>
        public JobRecurrence Recurrence
        {
            get { return this._recurrence; }
            set { this._recurrence = value; }
        }
        
        private System.DateTime? _startTime;
        
        /// <summary>
        /// Start time for the job.  Defined as ISO-8601.
        /// </summary>
        public System.DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private JobState _state;
        
        /// <summary>
        /// Current state of the job.
        /// </summary>
        public JobState State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private JobStatus _status;
        
        /// <summary>
        /// Current status of the job.
        /// </summary>
        public JobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        public Job()
        {
        }
    }
}