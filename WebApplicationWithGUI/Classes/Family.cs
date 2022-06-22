﻿namespace WebApplicationWithGUI.Classes
{
    public class Family
    {
        public int id { get; set; } = 0;
        public string full_name { get; set; } = "";
        public string gender { get; set; } = "";
        public int age { get; set; } = 0;
        public Relation relation { get; set; } = Relation.None;
        public Family()
        {
            id = 0; full_name = ""; gender = ""; age = 0; relation = Relation.None;
        }
        public Family(int iId, string sFullName, string sGender, int iAge, Relation eRelation)
        {
            id = iId; full_name = sFullName; gender = sGender; age = iAge; relation = eRelation;
        }
        public override string ToString()
        {
            return $"ID : {id}, Full Name : {full_name}, Gender : {gender}, Age : {age}, Relation : {relation}";
        }
    }
    public enum Relation { Father, Mother, Brother, Sister, None }
}
