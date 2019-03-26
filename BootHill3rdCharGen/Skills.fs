module Skills

open Attributes
open Microsoft.FSharp.Reflection

type WeaponSkills = Archery|Blades|Brawling|Pistol|Rifle
let weaponSkills = FSharpType.GetUnionCases typeof<WeaponSkills>

let getWeaponSkillName weaponSkill = 
    match weaponSkill with
    |Archery -> "Archery"
    |Blades -> "Blades"
    |Brawling -> "Brawling"
    |Pistol -> "Pistol"
    |_ -> "Rifle"

type WorkSkills = 
    Accounting|Artillerist|Artist|Assaying|Bartending|Blacksmithing|Bureaucracy|Carpentry|Chemistry|CivilEngineering
    |Cooking|CowHandling|Dentistry|Entertainer|Explosives|Farming|FastDraw|Gambling|Gunsmithing|IndianContact|Law
    |Leadership|Linguistics|Literacy|Locksmithing|Medicine|Orienteering|Photography|PocketPicking|Preaching|Prospecting
    |PublicSpeaking|Railroading|Riding|Roping|Saddlery|Scouting|Sheepherding|Silversmithing|Stealth|Surveying|Survival
    |Swimming|Tactics|Tailor|Teamster|Telegraph|Thespian|Throwing|Tracking|Trading|Trapping|Veterinarian|Wainwright
    |Whip|Wrangling|Wordsmithing
    
let getWorkSkillName workSkill = 
    match workSkill with
    |Accounting -> "Accounting"
    |Artillerist -> "Artillerist"
    |Artist -> "Artist"
    |Assaying -> "Assaying"
    |Bartending -> "Bartending"
    |Blacksmithing -> "Blacksmithing"
    |Bureaucracy -> "Bureaucracy"
    |Carpentry -> "Carpentry"
    |Chemistry -> "Chemistry"
    |CivilEngineering -> "Civil Engineering"
    |Cooking -> "Cooking"
    |CowHandling -> "Cow Handling"
    |Dentistry -> "Dentistry"
    |Entertainer -> "Entertainer"
    |Explosives -> "Explosives"
    |Farming -> "Farming"
    |FastDraw -> "Fast Draw"
    |Gambling -> "Gambling"
    |Gunsmithing -> "Gunsmithing"
    |IndianContact -> "Indian Contact"
    |Law -> "Law"
    |Leadership -> "Leadership"
    |Linguistics -> "Linguistics"
    |Literacy -> "Literacy"
    |Locksmithing -> "Locksmithing"
    |Medicine -> "Medicine"
    |Orienteering -> "Orienteering"
    |Photography -> "Photography"
    |PocketPicking -> "Pocket Picking"
    |Preaching -> "Preaching"
    |Prospecting -> "Prospecting"
    |PublicSpeaking -> "Public Speaking"
    |Railroading -> "Railroading"
    |Riding -> "Riding"
    |Roping -> "Roping"
    |Saddlery -> "Saddlery"
    |Scouting -> "Scouting"
    |Sheepherding -> "Sheepherding"
    |Silversmithing -> "Silversmithing"
    |Stealth -> "Stealth"
    |Surveying -> "Surveying"
    |Survival -> "Survival"
    |Swimming -> "Swimming"
    |Tactics -> "Tactics"
    |Tailor -> "Tailor"
    |Teamster -> "Teamster"
    |Telegraph -> "Telegraph"
    |Thespian -> "Thespian"
    |Throwing -> "Throwing"
    |Tracking -> "Tracking"
    |Trading -> "Trading"
    |Trapping -> "Trapping"
    |Veterinarian -> "Veterinarian"
    |Wainwright -> "Wainwright"
    |Whip -> "Whip"
    |Wrangling -> "Wrangling"
    |_ -> "Wordsmithing"

//type Skills = WeaponSkills of WeaponSkills|WorkSkills of WorkSkills

//let printWorkSkills = fun() -> weaponSkills |> List.iter (fun s -> printfn "%s" s.Name)

let initSkills total =
    match total with
    |total when total >= 27 && total <= 40 -> 10
    |total when total >= 41 && total <= 62 -> 8
    |_ -> 6  

//let workSkillsPage1 = 
//    [
//    "1-Accounting";"2-Artillerist";"3-Artist";"4-Assaying"; "5-Bartending";
//    "6-Bureaucracy"; "7-Carpentry";"8-Chemistry";"9-Civil Engineering";"10-Cooking";
//    "11-Cow Handling";"12-Dentistry";"13-Entertainer";"14-Explosives";"15-Farming"
//    ]
//let workSkillsPage2 = 
//    [
//    "16-Fast Draw";"17-Gambling";"18-Gunsmithing";"19-Indian Contact";"20-Law";
//    "21-Leadership";"22-Linguistics";"23-Literacy";"24-Locksmithing";"25-Medicine";
//    "26-Orienteering";"27-Pocket Picking";"28-Preaching";"29-Prospecting";"30-Public Speaking"
//    ]
//let workSkillsPage3 =
//    [
//    "31-Railroading";"32-Riding";"33-Roping";"34-Saddlery";"35-Scouting";
//    "36-Sheepherding";"37-Silversmithing";"38-Blacksmithing";"39-Stealth";"40-Surveying";
//    "41-Survival";"42-Swimming";"43-Tactics";"44-Tailoring";"45-Teamster"
//    ]
//let workSkillsPage4 =
//    [
//    "46-Telegraph";"47-Thespian";"48-Tracking";"49-Trading";"50-Trapping";
//    "51-Veterinary Medicine";"52-Wainwright";"53-Wordsmithing";"54-Wrangling";"55-Throwing";
//    "56-Whip";"57-Photography"
//    ]
//let workSkills = [workSkillsPage1;workSkillsPage2;workSkillsPage3;workSkillsPage4]

//let printWorkSkills = workSkills |> List.iter (fun ws -> ws |> List.iter (fun p -> printfn "%s" p ))    


