module Skills

open Utils

type WeaponSkills = Archery|Blades|Brawling|Pistol|Rifle

let weaponSkills = [Archery;Blades;Brawling;Pistol;Rifle]

let getWeaponSkill i = weaponSkills.Item(i)

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

let workSkills = 
    [Accounting;Artillerist;Artist;Assaying;Bartending;Blacksmithing;Bureaucracy;Carpentry;Chemistry;CivilEngineering;Cooking;CowHandling;
    Dentistry;Entertainer;Explosives;Farming;FastDraw;Gambling;Gunsmithing;IndianContact;Law;Leadership;Linguistics;Literacy;
    Locksmithing;Medicine;Orienteering;Photography;PocketPicking;Preaching;Prospecting;PublicSpeaking;Railroading;Riding;Roping;Saddlery;
    Scouting;Sheepherding;Silversmithing;Stealth;Surveying;Survival;Swimming;Tactics;Tailor;Teamster;Telegraph;Thespian;
    Throwing;Tracking;Trading;Trapping;Veterinarian;Wainwright;Whip;Wrangling;Wordsmithing]

let getWorkSkill i = workSkills.Item(i)    

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

let printWorkSkills = fun() -> workSkills |> List.iteri (fun i ws ->
    let workSkillName = getWorkSkillName ws 
    printfn "%i - %s" (refIndex i) workSkillName)

let initSkills total =
    match total with
    |total when total >= 27 && total <= 40 -> 10
    |total when total >= 41 && total <= 62 -> 8
    |_ -> 6

//type BHSkill = WorkSkill of WorkSkills|WeaponSkill of WeaponSkills

// let printBHSkillName skill = 
//     match skill with
//     | :? WorkSkills as work -> printWorkSkillName work
//     | :? WeaponSkills as weapon -> printWeaponSkillName weapon
//     |_ -> ignore
