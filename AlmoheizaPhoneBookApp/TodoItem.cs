using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace AlmoheizaPhoneBookApp
{
	public class TodoItem
	{
		string id;
		string name;
        string city;
        string job;
        string number;
        string email;
        string sons;


		bool done;

		[JsonProperty(PropertyName = "id")]
		public string Id
		{
			get { return id; }
			set { id = value;}
		}

        [JsonProperty(PropertyName = "test")]
        public string Test { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name
		{
			get { return name; }
			set { name = value;}
		}

		[JsonProperty(PropertyName = "complete")]
		public bool Done
		{
			get { return done; }
			set { done = value;}
		}

        [JsonProperty(PropertyName = "city")]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        [JsonProperty(PropertyName ="job")]
        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        [JsonProperty(PropertyName = "number")]
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        [JsonProperty(PropertyName = "email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [JsonProperty(PropertyName = "sons")]
        public string Sons
        {
            get { return sons; }
            set { sons = value; }
        }

        [Version]
        public string Version { get; set; }
	}
}

