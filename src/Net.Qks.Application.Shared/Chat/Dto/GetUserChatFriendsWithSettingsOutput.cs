using System;
using System.Collections.Generic;
using Castle.Components.DictionaryAdapter;
using Net.Qks.Friendships.Dto;

namespace Net.Qks.Chat.Dto
{
    public class GetUserChatFriendsWithSettingsOutput
    {
        public DateTime ServerTime { get; set; }
        
        public List<FriendDto> Friends { get; set; }

        public GetUserChatFriendsWithSettingsOutput()
        {
            Friends = new EditableList<FriendDto>();
        }
    }
}