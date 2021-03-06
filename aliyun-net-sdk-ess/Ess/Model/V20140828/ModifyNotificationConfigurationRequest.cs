/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class ModifyNotificationConfigurationRequest : RpcAcsRequest<ModifyNotificationConfigurationResponse>
    {
        public ModifyNotificationConfigurationRequest()
            : base("Ess", "2014-08-28", "ModifyNotificationConfiguration", "ess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string scalingGroupId;

		private string notificationArn;

		private string resourceOwnerAccount;

		private long? ownerId;

		private List<string> notificationTypes = new List<string>(){ };

		public string ScalingGroupId
		{
			get
			{
				return scalingGroupId;
			}
			set	
			{
				scalingGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId", value);
			}
		}

		public string NotificationArn
		{
			get
			{
				return notificationArn;
			}
			set	
			{
				notificationArn = value;
				DictionaryUtil.Add(QueryParameters, "NotificationArn", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public List<string> NotificationTypes
		{
			get
			{
				return notificationTypes;
			}

			set
			{
				notificationTypes = value;
				for (int i = 0; i < notificationTypes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"NotificationType." + (i + 1) , notificationTypes[i]);
				}
			}
		}

        public override ModifyNotificationConfigurationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyNotificationConfigurationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
