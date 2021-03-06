﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotsAPI
{
    /// <summary>
    /// This object represents a group chat.
    /// </summary>
    [JsonObject()]
    public class GroupChat
    {
        /// <summary>
        /// Unique identifier for this group chat.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// Group name.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
