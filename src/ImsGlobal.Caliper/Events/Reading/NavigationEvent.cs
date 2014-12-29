﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Events.Reading {
	using ImsGlobal.Caliper.Actions;
	using ImsGlobal.Caliper.Entities;

	/// <summary>
	/// Event raised when an actor navigates from one resource to another.
	/// </summary>
	public class NavigationEvent : Event {

		public NavigationEvent() {
			this.Context = EventContext.Navigation.Uri;
			this.Type = EventType.Navigation.Uri;
			this.Action = ReadingAction.NavigatedTo.Value;
		}

		/// <summary>
		/// The resource from which the navigation starts.
		/// </summary>
		[JsonProperty( "navigatedFrom", Order = 99 )]
		public DigitalResource FromResource { get; set; }

	}

}