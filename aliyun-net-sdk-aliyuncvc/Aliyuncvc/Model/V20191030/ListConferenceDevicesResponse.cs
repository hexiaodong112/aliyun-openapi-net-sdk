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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.aliyuncvc.Model.V20191030
{
	public class ListConferenceDevicesResponse : AcsResponse
	{

		private int? errorCode;

		private string message;

		private bool? success;

		private string requestId;

		private ListConferenceDevices_ConferencesDatas conferencesDatas;

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public ListConferenceDevices_ConferencesDatas ConferencesDatas
		{
			get
			{
				return conferencesDatas;
			}
			set	
			{
				conferencesDatas = value;
			}
		}

		public class ListConferenceDevices_ConferencesDatas
		{

			private int? total;

			private int? pageSize;

			private int? pageNumber;

			private List<ListConferenceDevices_Data> conferences;

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public List<ListConferenceDevices_Data> Conferences
			{
				get
				{
					return conferences;
				}
				set	
				{
					conferences = value;
				}
			}

			public class ListConferenceDevices_Data
			{

				private string activationCode;

				private string conferenceCode;

				private string conferenceName;

				private string createTime;

				private string deviceModel;

				private string manufacturer;

				private string pictureUrl;

				private string sN;

				private string status;

				private string castScreenCode;

				public string ActivationCode
				{
					get
					{
						return activationCode;
					}
					set	
					{
						activationCode = value;
					}
				}

				public string ConferenceCode
				{
					get
					{
						return conferenceCode;
					}
					set	
					{
						conferenceCode = value;
					}
				}

				public string ConferenceName
				{
					get
					{
						return conferenceName;
					}
					set	
					{
						conferenceName = value;
					}
				}

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public string DeviceModel
				{
					get
					{
						return deviceModel;
					}
					set	
					{
						deviceModel = value;
					}
				}

				public string Manufacturer
				{
					get
					{
						return manufacturer;
					}
					set	
					{
						manufacturer = value;
					}
				}

				public string PictureUrl
				{
					get
					{
						return pictureUrl;
					}
					set	
					{
						pictureUrl = value;
					}
				}

				public string SN
				{
					get
					{
						return sN;
					}
					set	
					{
						sN = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string CastScreenCode
				{
					get
					{
						return castScreenCode;
					}
					set	
					{
						castScreenCode = value;
					}
				}
			}
		}
	}
}
