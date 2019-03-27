module BHChar

open Attributes
open Skills

type Skill = { Skill:BHSkill; BaseAttr:Attribute; Bonus:int }

//type BHChar = { Name:string; Attributes:Attribute list; Skills:CharSkill list }

//let newChar name attrs skills = { Name=name; Attributes=attrs; Skills=skills }

