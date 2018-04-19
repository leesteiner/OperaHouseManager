using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouseManager
{
    class Role
    {
        public string Name { get; set; }
        public VoiceType voiceType { get; set; }
        public RoleClass roleClass { get; set; }


        public Role() { }
        public Role(string name)
            : this(name, VoiceType.Undefined, RoleClass.Undefined) { }
        public Role(string name, VoiceType voicetype, RoleClass roleclass)
        {
            Name = name;
            voiceType = voicetype;
            roleClass = roleclass;
        }
    }
}
