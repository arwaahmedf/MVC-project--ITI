﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Center_ElGhalaba.Models
{
    public class Level
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Stage")]
        public int StageId { get; set; }
        public virtual Stage Stage { get; set; }

        public virtual List<LevelSubject> Subjects { get; set; }

    }
}
