﻿using Newtonsoft.Json;

namespace XIVDeck.FFXIVPlugin.Server.Messages.Outbound {
    public class WSShowSDAlert  : BaseOutboundMessage {
        private static string MESSAGE_NAME = "sdAlert";

        [JsonProperty("context")] public string Context { get; set; }

        public WSShowSDAlert() : base(MESSAGE_NAME) {
            
        }

        public WSShowSDAlert(string context) : base(MESSAGE_NAME) {
            this.Context = context;
        }
    }
}