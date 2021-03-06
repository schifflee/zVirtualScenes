﻿using System.ComponentModel.DataAnnotations.Schema;

namespace zvs.DataModel
{
    [Table("SceneSettingOptions", Schema = "ZVS")]
    public class SceneSettingOption : BaseOption, IIdentity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int SceneSettingId { get; set; }
        public virtual SceneSetting SceneSetting { get; set; }
    }
}
