﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSTaskDependencies
    {
        
        internal Microsoft.Azure.Batch.TaskDependencies omObject;
        
        private IReadOnlyList<PSTaskIdRange> taskIdRanges;
        
        private IReadOnlyList<System.String> taskIds;
        
        public PSTaskDependencies(System.Collections.Generic.IEnumerable<string> taskIds, System.Collections.Generic.IEnumerable<Microsoft.Azure.Batch.TaskIdRange> taskIdRanges)
        {
            this.omObject = new Microsoft.Azure.Batch.TaskDependencies(taskIds, taskIdRanges);
        }
        
        internal PSTaskDependencies(Microsoft.Azure.Batch.TaskDependencies omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public IReadOnlyList<PSTaskIdRange> TaskIdRanges
        {
            get
            {
                if (((this.taskIdRanges == null) 
                            && (this.omObject.TaskIdRanges != null)))
                {
                    List<PSTaskIdRange> list;
                    list = new List<PSTaskIdRange>();
                    IEnumerator<Microsoft.Azure.Batch.TaskIdRange> enumerator;
                    enumerator = this.omObject.TaskIdRanges.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSTaskIdRange(enumerator.Current));
                    }
                    this.taskIdRanges = list.AsReadOnly();
                }
                return this.taskIdRanges;
            }
        }
        
        public IReadOnlyList<System.String> TaskIds
        {
            get
            {
                if (((this.taskIds == null) 
                            && (this.omObject.TaskIds != null)))
                {
                    List<System.String> list;
                    list = new List<System.String>();
                    IEnumerator<System.String> enumerator;
                    enumerator = this.omObject.TaskIds.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(enumerator.Current);
                    }
                    this.taskIds = list.AsReadOnly();
                }
                return this.taskIds;
            }
        }
    }
}
