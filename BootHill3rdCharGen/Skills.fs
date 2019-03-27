module Skills

open Utils

type BHSkill = { Name:string; Description:string }

let newSkill name desc = { Name=name; Description=desc }

let Accounting = newSkill "Accounting" ""
let Archery = newSkill "Archery" ""
let Artillerist = newSkill "Artillerist" ""
let Artist = newSkill "Artist" ""
let Assaying = newSkill "Assaying" ""
let Bartending = newSkill "Bartending" ""
let Blacksmithing = newSkill "Blacksmithing" ""
let Blades = newSkill "Blades" ""
let Brawling = newSkill "Brawling" ""
let Bureaucracy = newSkill "Bureaucracy" ""
let Carpentry = newSkill "Carpentry" ""
let Chemistry = newSkill "Chemistry" ""
let CivilEngineering = newSkill "Civil Engineering" ""
let Cooking = newSkill "Cooking" ""
let CowHandling = newSkill "CowHandling" ""
let Dentistry = newSkill "Dentistry" ""
let Entertainer = newSkill "Entertainer" ""
let Explosives = newSkill "Explosives" ""
let Farming = newSkill "Farming" ""
let FastDraw = newSkill "FastDraw" ""
let Gambling = newSkill "Gambling" ""
let Gunsmithing = newSkill "Gunsmithing" ""
let IndianContact = newSkill "Indian Contact" ""
let Law = newSkill "Law" ""    
let Leadership = newSkill "Leadership" ""
let Linguistics = newSkill "Linguistics" ""
let Literacy = newSkill "Literacy" ""
let Locksmithing = newSkill "Locksmithing" ""
let Medicine = newSkill "Medicine" ""
let Orienteering = newSkill "Orienteering" ""
let Photography = newSkill "Photography" ""
let Pistol = newSkill "Pistol" ""
let PocketPicking = newSkill "Pocket Picking" ""
let Preaching = newSkill "Preaching" ""
let Prospecting = newSkill "Prospecting" ""
let PublicSpeaking = newSkill "Public Speaking" ""
let Railroading = newSkill "Railroading" ""
let Riding = newSkill "Riding" ""
let Rifle = newSkill "Rifle" ""
let Roping = newSkill "Roping" ""
let Saddlery = newSkill "Saddlery" ""
let Scouting = newSkill "Scouting" ""
let Sheepherding = newSkill "Sheepherding" ""
let Silversmithing = newSkill "Silversmithing" ""
let Stealth = newSkill "Stealth" ""
let Surveying = newSkill "Surveying" ""
let Survival = newSkill "Survival" ""
let Swimming = newSkill "Swimming" ""
let Tactics = newSkill "Tactics" ""
let Tailor = newSkill "Tailor" ""
let Teamster = newSkill "Teamster" ""
let Telegraph = newSkill "Telegraph" ""
let Thespian = newSkill "Thespian" ""
let Throwing = newSkill "Throwing" ""
let Tracking = newSkill "Tracking" ""
let Trading = newSkill "Trading" ""
let Trapping = newSkill "Trapping" ""
let Veterinarian = newSkill "Veterinarian" ""
let Wainwright = newSkill "Wainwright" ""
let Whip = newSkill "Whip" ""
let Wrangling = newSkill "Wrangling" ""
let Wordsmithing = newSkill "Wordsmithing" ""

let workSkills = 
    [Accounting;Artillerist;Artist;Assaying;Bartending;Blacksmithing;Bureaucracy;Carpentry;Chemistry;CivilEngineering;Cooking;CowHandling;
    Dentistry;Entertainer;Explosives;Farming;FastDraw;Gambling;Gunsmithing;IndianContact;Law;Leadership;Linguistics;Literacy;
    Locksmithing;Medicine;Orienteering;Photography;PocketPicking;Preaching;Prospecting;PublicSpeaking;Railroading;Riding;Roping;Saddlery;
    Scouting;Sheepherding;Silversmithing;Stealth;Surveying;Survival;Swimming;Tactics;Tailor;Teamster;Telegraph;Thespian;
    Throwing;Tracking;Trading;Trapping;Veterinarian;Wainwright;Whip;Wrangling;Wordsmithing]

let weaponSkills = [Archery;Blades;Brawling;Pistol;Rifle]

let printSkillName skill = printfn "%s" skill.Name

let printSkillList skillList = skillList |> List.iteri (fun i s -> printfn "%i - %s" (refIndex i) s.Name)

let initSkills total =
    match total with
    |total when total >= 27 && total <= 40 -> 10
    |total when total >= 41 && total <= 62 -> 8
    |_ -> 6
