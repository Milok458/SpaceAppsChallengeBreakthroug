using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject spaceStore;
    public GameObject projectsPanel;
    public GameObject missionsPanel;

    void Start()
    {
        List<Engine> engines = GenerateEngines();

        List<Mission> missions = GenerateMissions();

        List<Project> projects = GenerateProjects();

        for(int i=0; i<8; i++)
        {
            spaceStore.transform.GetChild(i).GetComponent<StorePanel>().SetEngine(engines[i]);
            spaceStore.transform.GetChild(i).GetComponent<StorePanel>().SetData();

            projectsPanel.transform.GetChild(i).GetComponent<ProjectPanel>().SetProject(projects[i]);
            projectsPanel.transform.GetChild(i).GetComponent<ProjectPanel>().SetData();
        }

        for(int j=0; j<20; j++)
        {
            missionsPanel.transform.GetChild(j).GetComponent<MissionPanel>().SetMission(missions[j]);
        }
    }

    private List<Engine> GenerateEngines()
    {
        List<Engine> engines = new List<Engine>
        {
            new Engine("S5.4", "The S5.4 was a Russian liquid rocket engine burning TG-02 and AK20F in the gas generator cycle. This was the first ever rocket engine to fully orbit the earth.", 15830, 0, 100000),
            new Engine("F-1 ROCKETDYNE", "The F-1 Rocketdyne engine is a gas generator-cycle rocket engine developed in the United States by Rocketdyne in the late 1950s and was the main engine in the apollo program. It was with this engine that man made it to the moon.", 6770000, 150000, 175000),
            new Engine("RS-25 ROCKET", "The RS-25 engine developed by Rocketdyne is a liquid-fuel cryogenic rocket engine that was used on NASA's Space Shuttle and will be used in NASA's upcoming space launch system.", 2200000, 375000, 250000),
            new Engine("SPACEX RAPTOR", "The SpaceX Raptor is a highly reusable full-flow staged combustion, methane-fueled rocket engine manufactured by SpaceX. This rocket is mainly being developed for mars missions.", 2000000, 940000, 225000),
            new Engine("SOLAR SAILS", "Solar sails are a propulsion system that use light radiation to gain thrust which is very cheap since the only fuel is light form sun or any other star.", 240000, 2345000, 125000),
            new Engine("PROYECT DEADALUS", "Project Deadalus is a variant for nuclear pulse propulsion system. This one is powered by a nuclear fusion reactor and it sets the energy free in pulses to gain thrust. Since this is a very powerful reaction it allows the ship to reach speed up to 10% of light speed!", 40000000, 5860000, 2000000),
            new Engine("HELICAL ENGINE", "Helical engine will allow you to reach 99% of light speed. It works with an enclosed synchrotron that gives thrust to the ship but all this comes at a high cost. It will let you explore new areas in the universe but be aware for time dilation!", 299792458, 14650000, 20000000),
            new Engine("WARP ENGINE", "The Warp drive technology will let you travel to any point in space in an incredibly short period of time. We know this is possible thanks to Albert Einstein's relativity, which tells us we can bend space-time and that way you can get your destination closer instead of traveling through space!", -1, 36620000, 50000000)
        };

        return engines;
    }

    private List<Project> GenerateProjects()
    {
        List<Project> projects = new List<Project>
        {
            new Project("PUBLICITY", "Start a publicity campaign that will raise your presence in the market.", 30000, 50),
            new Project("SATELLITE NETWORK", "Launch a satellite network for internet and server hosting.", 150000, 75),
            new Project("LUNAR BASE", "Stablish a lunar base for scientific research.", 200000, 100),
            new Project("MARTIAN BASE", "Stablish a Martian base and plant the seed for interplanetary civilization.", 350000, 125),
            new Project("NEAR ASTEROID MINING", "Mine the resources from the asteroid belt.", 500000, 150),
            new Project("SPACE TOURISM", "Start a space tourism agency. Sit back and enjoy de view!", 700000, 200),
            new Project("PLANETARY TRADING", "Use autonomous Ionic propelled ships that make the planetary communication and trading much easier.", 1000000, 250),
            new Project("DYSON SPHERE", "Build a mega structure that harvests the energy from the sun. At this point you have reached the peak of civilizations.", 150000000, 0),
        };

        return projects;
    }

    private List<Mission> GenerateMissions()
    {
        List<Mission> missions = new List<Mission>
        {
            new Mission("ORBIT", "Orbit is the closest position to Earth in space. It is where most satellites and the ISS are located.", 340, 20000),
            new Mission("MOON", "The moon is the only astronomical body orbiting the earth.", 384000, 35000),
            new Mission("VENUS", "Venus is the most similar planet to Earth and the closest but in its surface it is too hot to handle and its atmosphere is too toxic for life as we know it.", 40000000, 50000),
            new Mission("MERCURY", "Mercury is the inmost planet of the entire solar system, it has an orbit of just 87.97 days", 222000000, 55000),
            new Mission("MARS", "Mars is the planet that goes after earth and it is the most likely for humanity to inhabit soon!", 225000000, 60000),
            new Mission("JUPITER", "Jupiter is a gas giant and is the biggest celestial body in the solar system, only smaller than the sun.", 660000000, 100000),
            new Mission("SATURN", "Saturn is the planet with the widest rings in our solar system. You can even look at them from here!", 1275000000, 150000),
            new Mission("URANUS", "Uranus is the coldest planet in our solar system having an average temperature of -205°C.", 3000000000, 200000),
            new Mission("PLUTO", "Pluto is a planet... or not? Anyways, it is the farthest planet(?) from our solar system and also the smallest.", 5500000000, 250000),
            new Mission("PROXIMA CENTAURI", "Proxima centauri is the closest star to our solar system.", (4.24) * (9.46) * (1000000000000), 750000),
            new Mission("BERNARD'S STAR", "Barnard's star is the fastest moving star in the Earth's sky. It is also known to be the closest red dwarf from us.", (5.96) * (9.46) * (1000000000000), 1000000),
            new Mission("SIRIUS", "Sirius from the canis major constellation is the brightest star in the night sky and will continue to be for the next 210,000 years.", (8.58) * (9.46) * (1000000000000), 1250000),
            new Mission("RAN", "Ran is a main star from the constellation Eridanus and it is visible from Earth with the naked eye.", (10.52) * (9.46) * (1000000000000), 1750000),
            new Mission("EPSILON INDI", "Epsilon Indi  is a star system in the constellation of Indus consisting of a K-type main-sequence star, ε Indi A, and two brown dwarfs, ε Indi Ba and ε Indi Bb, in a wide orbit around it.", (11.82) * (9.46) * (1000000000000), 2700000),
            new Mission("AU MC B", "AU mic b is a recently discovered planet by NASA. This planet is being studied to understand the early stages of planet formation.", (32) * (9.46) * (1000000000000), 3900000),
            new Mission("TRAPPIST-1", "Trappist-1 is a solar system from the Aquarius constellation which has a red dwarf not much bigger than Jupiter.", (39.46) * (9.46) * (1000000000000), 5000000),
            new Mission("KEPLER-1694C", "Kepler-1649c Is an exoplanet which is the most similar planet to earth that has been currently found.", (300) * (9.46) * (1000000000000), 15000000),
            new Mission("STEPEHNSON 2-18", "Stephenson 2-18 is a red supergiant being the biggest and brightest star currently known, its so massive that if placed at the center of the Solar System, its photosphere would engulf the orbit of Saturn.", (19570) * (9.46) * (1000000000000), 15000000),
            new Mission("MESSIER 87", "Messier-87 is the first black hole that has been photographed in human history! (Be careful not to get too close)", (53490000) * (9.46) * (1000000000000), 15000000),
            new Mission("GALAXY MACS0647", "This is the farthest galaxy known. If you want to get there make sure you bring a lot of food!", (13300000000) * (9.46) * (1000000000000), 15000000)
        };

        return missions;
    }

    void Update()
    {
        
    }
}
