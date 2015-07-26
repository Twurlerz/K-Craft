﻿#region C#raft License
// This file is part of C#raft. Copyright C#raft Team 
// 
// C#raft is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.
#endregion

using Chraft.PluginSystem.Args;

namespace Chraft.PluginSystem.Listener
{
    public class PluginListener : IChraftListener
    {
        public virtual void OnPluginEnabled(PluginEnabledEventArgs e) { }
        public virtual void OnPluginDisabled(PluginDisabledEventArgs e) { }
        public virtual void OnPluginCommandAdded(CommandAddedEventArgs e) { }
        public virtual void OnPluginCommandRemoved(CommandRemovedEventArgs e) { }
        public virtual void OnPluginListStatusChanged() { }
    }
}
