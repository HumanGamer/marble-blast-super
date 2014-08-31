<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2014/08/25 19:47:27">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="131">
                    <Brush id="1" owner="0" type="0" pos="-4 -3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="7 1 2" />
                            <Vertex pos="7 1 -2" />
                            <Vertex pos="7 -1 2" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="5 1 2" />
                            <Vertex pos="5 1 -2" />
                            <Vertex pos="5 -1 2" />
                            <Vertex pos="5 -1 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -2" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="2 -9 0.5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -9 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 3 5" />
                            <Vertex pos="9 3 -2" />
                            <Vertex pos="9 -3 5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="-9 3 5" />
                            <Vertex pos="-9 3 -2" />
                            <Vertex pos="-9 -3 5" />
                            <Vertex pos="-9 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="pattern_cool2" texgens="-1 0 0 -128 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="8 -3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 3 5" />
                            <Vertex pos="9 3 -2" />
                            <Vertex pos="9 -3 5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="-3 3 5" />
                            <Vertex pos="-3 3 -2" />
                            <Vertex pos="-3 -3 5" />
                            <Vertex pos="-3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 -3" album="levelcreating" material="pattern_cool2" texgens="0 -1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-10 -3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 3 5" />
                            <Vertex pos="9 3 -2" />
                            <Vertex pos="9 -3 5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="-3 3 5" />
                            <Vertex pos="-3 3 -2" />
                            <Vertex pos="-3 -3 5" />
                            <Vertex pos="-3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="pattern_cool2" texgens="0 1 0 -192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 256 0 0 -1 -224 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="2 3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 3 5" />
                            <Vertex pos="9 3 -2" />
                            <Vertex pos="9 -3 5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="-9 3 5" />
                            <Vertex pos="-9 3 -2" />
                            <Vertex pos="-9 -3 5" />
                            <Vertex pos="-9 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 704 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="pattern_cool2" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-4 -1 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -1 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="7 1 2" />
                            <Vertex pos="7 1 -2" />
                            <Vertex pos="7 -1 2" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="5 1 2" />
                            <Vertex pos="5 1 -2" />
                            <Vertex pos="5 -1 2" />
                            <Vertex pos="5 -1 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -2" album="levelcreating" material="pattern_cool1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-2 -1 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -1 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="7 1 2" />
                            <Vertex pos="7 1 -2" />
                            <Vertex pos="7 -1 2" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="5 1 2" />
                            <Vertex pos="5 1 -2" />
                            <Vertex pos="5 -1 2" />
                            <Vertex pos="5 -1 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -2" album="levelcreating" material="pattern_cool1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-2 -3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="7 1 2" />
                            <Vertex pos="7 1 -2" />
                            <Vertex pos="7 -1 2" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="5 1 2" />
                            <Vertex pos="5 1 -2" />
                            <Vertex pos="5 -1 2" />
                            <Vertex pos="5 -1 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -2" album="levelcreating" material="pattern_cool1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-2 -5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="7 1 2" />
                            <Vertex pos="7 1 -2" />
                            <Vertex pos="7 -1 2" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="5 1 2" />
                            <Vertex pos="5 1 -2" />
                            <Vertex pos="5 -1 2" />
                            <Vertex pos="5 -1 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -2" album="levelcreating" material="pattern_cool1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-6 -1 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -1 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="7 1 2" />
                            <Vertex pos="7 1 -2" />
                            <Vertex pos="7 -1 2" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="5 1 2" />
                            <Vertex pos="5 1 -2" />
                            <Vertex pos="5 -1 2" />
                            <Vertex pos="5 -1 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -2" album="levelcreating" material="pattern_cool1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-6 -3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="7 1 2" />
                            <Vertex pos="7 1 -2" />
                            <Vertex pos="7 -1 2" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="5 1 2" />
                            <Vertex pos="5 1 -2" />
                            <Vertex pos="5 -1 2" />
                            <Vertex pos="5 -1 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -2" album="levelcreating" material="pattern_cool1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-6 -5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="7 1 2" />
                            <Vertex pos="7 1 -2" />
                            <Vertex pos="7 -1 2" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="5 1 2" />
                            <Vertex pos="5 1 -2" />
                            <Vertex pos="5 -1 2" />
                            <Vertex pos="5 -1 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -2" album="levelcreating" material="pattern_cool1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-4 -5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="7 1 2" />
                            <Vertex pos="7 1 -2" />
                            <Vertex pos="7 -1 2" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="5 1 2" />
                            <Vertex pos="5 1 -2" />
                            <Vertex pos="5 -1 2" />
                            <Vertex pos="5 -1 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -2" album="levelcreating" material="pattern_cool1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="8 3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="8 7 0.5" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 7 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="4 3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="4 7 0.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 7 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="6 3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="6 3 8" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 3 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="8 5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="8 5 8" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="4 5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="4 5 8" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="6 7 0.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 7 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="6 7 8" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 7 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="-16 3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="-16 7 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 7 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="-20 3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="-20 7 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 7 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-18 3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-18 3 8" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 3 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-16 5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="-16 5 8" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="-20 5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="-20 5 8" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="-18 7 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 7 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-18 7 8" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 7 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-16 -9 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -9 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="-16 -5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="-20 -9 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -9 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="-20 -5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="-18 -9 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -9 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-18 -9 8" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -9 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="-16 -7 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -7 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="-16 -7 8" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -7 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-20 -7 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -7 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-20 -7 8" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -7 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-18 -5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-18 -5 8" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="8 -9 0.5" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -9 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="8 -5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="4 -9 0.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -9 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="4 -5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 17.5" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 17.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 17.5" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 17.5" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -17.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="6 -9 0.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -9 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="6 -9 8" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -9 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="8 -7 0.5" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -7 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="8 -7 8" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -7 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="4 -7 0.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -7 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="4 -7 8" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -7 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="6 -5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 12.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 12.5" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="6 -5 8" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 -5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 10" />
                            <Vertex pos="9 -1 7" />
                            <Vertex pos="9 -3 10" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="7 -1 10" />
                            <Vertex pos="7 -1 7" />
                            <Vertex pos="7 -3 10" />
                            <Vertex pos="7 -3 7" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 7" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="6 1 0.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 1 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 12" />
                            <Vertex pos="9 -7 12.5" />
                            <Vertex pos="9 -7 12" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 12" />
                            <Vertex pos="7 -7 12.5" />
                            <Vertex pos="7 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 12" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-18 1 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 1 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 12" />
                            <Vertex pos="9 -7 12.5" />
                            <Vertex pos="9 -7 12" />
                            <Vertex pos="7 -1 12.5" />
                            <Vertex pos="7 -1 12" />
                            <Vertex pos="7 -7 12.5" />
                            <Vertex pos="7 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 12" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-13.5 -3 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 -3 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="24.5 -5 12.5" />
                            <Vertex pos="24.5 -5 12" />
                            <Vertex pos="24.5 -7 12.5" />
                            <Vertex pos="24.5 -7 12" />
                            <Vertex pos="6.5 -5 12.5" />
                            <Vertex pos="6.5 -5 12" />
                            <Vertex pos="6.5 -7 12.5" />
                            <Vertex pos="6.5 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -24.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 6.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 12" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="-13.5 9 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 9 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="24.5 -5 12.5" />
                            <Vertex pos="24.5 -5 12" />
                            <Vertex pos="24.5 -7 12.5" />
                            <Vertex pos="24.5 -7 12" />
                            <Vertex pos="6.5 -5 12.5" />
                            <Vertex pos="6.5 -5 12" />
                            <Vertex pos="6.5 -7 12.5" />
                            <Vertex pos="6.5 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -24.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 6.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 12" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="-10 3 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 3 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 14" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 14" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 14" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 14" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -14" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-2 3 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 3 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 14" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 14" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 14" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 14" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -14" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="-10 -5 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -5 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 14" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 14" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 14" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 14" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -14" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="-2 -5 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -5 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 14" />
                            <Vertex pos="9 -1 -2" />
                            <Vertex pos="9 -3 14" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="7 -1 14" />
                            <Vertex pos="7 -1 -2" />
                            <Vertex pos="7 -3 14" />
                            <Vertex pos="7 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 7" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -14" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="-4 1 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 1 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -1 12.5" />
                            <Vertex pos="9 -1 12" />
                            <Vertex pos="9 -7 12.5" />
                            <Vertex pos="9 -7 12" />
                            <Vertex pos="3 -1 12.5" />
                            <Vertex pos="3 -1 12" />
                            <Vertex pos="3 -7 12.5" />
                            <Vertex pos="3 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 12" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="-4 7 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 7 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -5 12.5" />
                            <Vertex pos="9 -5 12" />
                            <Vertex pos="9 -7 12.5" />
                            <Vertex pos="9 -7 12" />
                            <Vertex pos="3 -5 12.5" />
                            <Vertex pos="3 -5 12" />
                            <Vertex pos="3 -7 12.5" />
                            <Vertex pos="3 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="pattern_warm1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 12" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="-4 -1 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -1 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 -5 12.5" />
                            <Vertex pos="9 -5 12" />
                            <Vertex pos="9 -7 12.5" />
                            <Vertex pos="9 -7 12" />
                            <Vertex pos="3 -5 12.5" />
                            <Vertex pos="3 -5 12" />
                            <Vertex pos="3 -7 12.5" />
                            <Vertex pos="3 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="pattern_warm1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 12" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="2 1 0.5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 1 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="5 -1 12.5" />
                            <Vertex pos="5 -1 12" />
                            <Vertex pos="5 -7 12.5" />
                            <Vertex pos="5 -7 12" />
                            <Vertex pos="3 -1 12.5" />
                            <Vertex pos="3 -1 12" />
                            <Vertex pos="3 -7 12.5" />
                            <Vertex pos="3 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="pattern_warm1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 12" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-6 1 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 1 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="5 -1 12.5" />
                            <Vertex pos="5 -1 12" />
                            <Vertex pos="5 -7 12.5" />
                            <Vertex pos="5 -7 12" />
                            <Vertex pos="3 -1 12.5" />
                            <Vertex pos="3 -1 12" />
                            <Vertex pos="3 -7 12.5" />
                            <Vertex pos="3 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="pattern_warm1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 12" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-16 -9 -1" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -9 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 3 -0.5" />
                            <Vertex pos="9 3 -2" />
                            <Vertex pos="9 -3 -0.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="3 3 -0.5" />
                            <Vertex pos="3 3 -2" />
                            <Vertex pos="3 -3 -0.5" />
                            <Vertex pos="3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="pattern_cool2" texgens="-1 0 0 -128 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 0.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-22 -9 -1" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -9 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 15 -0.5" />
                            <Vertex pos="9 15 -2" />
                            <Vertex pos="9 -3 -0.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="3 15 -0.5" />
                            <Vertex pos="3 15 -2" />
                            <Vertex pos="3 -3 -0.5" />
                            <Vertex pos="3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -15" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 320 0 0 -1 -32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 0.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-16 3 -1" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 3 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 3 -0.5" />
                            <Vertex pos="9 3 -2" />
                            <Vertex pos="9 -3 -0.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="3 3 -0.5" />
                            <Vertex pos="3 3 -2" />
                            <Vertex pos="3 -3 -0.5" />
                            <Vertex pos="3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 -64 0 0 -1 -32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 0.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-16 9 -1" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 9 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="33 3 -0.5" />
                            <Vertex pos="33 3 -2" />
                            <Vertex pos="33 -3 -0.5" />
                            <Vertex pos="33 -3 -2" />
                            <Vertex pos="-3 3 -0.5" />
                            <Vertex pos="-3 3 -2" />
                            <Vertex pos="-3 -3 -0.5" />
                            <Vertex pos="-3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -33" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 -64 0 0 -1 -32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 0.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="14 -9 -1" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 -9 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 15 -0.5" />
                            <Vertex pos="9 15 -2" />
                            <Vertex pos="9 -3 -0.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="3 15 -0.5" />
                            <Vertex pos="3 15 -2" />
                            <Vertex pos="3 -3 -0.5" />
                            <Vertex pos="3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -15" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 320 0 0 -1 -32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 0.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-16 -15 -1" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -15 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="33 3 -0.5" />
                            <Vertex pos="33 3 -2" />
                            <Vertex pos="33 -3 -0.5" />
                            <Vertex pos="33 -3 -2" />
                            <Vertex pos="-3 3 -0.5" />
                            <Vertex pos="-3 3 -2" />
                            <Vertex pos="-3 -3 -0.5" />
                            <Vertex pos="-3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -33" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 -64 0 0 -1 -32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 0.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="8 -9 -1" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -9 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 3 -0.5" />
                            <Vertex pos="9 3 -2" />
                            <Vertex pos="9 -3 -0.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="3 3 -0.5" />
                            <Vertex pos="3 3 -2" />
                            <Vertex pos="3 -3 -0.5" />
                            <Vertex pos="3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="pattern_cool2" texgens="-1 0 0 -128 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 0.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="8 3 -1" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 3 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 3 -0.5" />
                            <Vertex pos="9 3 -2" />
                            <Vertex pos="9 -3 -0.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="3 3 -0.5" />
                            <Vertex pos="3 3 -2" />
                            <Vertex pos="3 -3 -0.5" />
                            <Vertex pos="3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="pattern_cool2" texgens="-1 0 0 -128 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 0.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="14 9 -1" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 9 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 3 -0.5" />
                            <Vertex pos="9 3 -2" />
                            <Vertex pos="9 -3 -0.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="3 3 -0.5" />
                            <Vertex pos="3 3 -2" />
                            <Vertex pos="3 -3 -0.5" />
                            <Vertex pos="3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 -1984 0 0 -1 -32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 0.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="14 -15 -1" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 -15 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="9 3 -0.5" />
                            <Vertex pos="9 3 -2" />
                            <Vertex pos="9 -3 -0.5" />
                            <Vertex pos="9 -3 -2" />
                            <Vertex pos="3 3 -0.5" />
                            <Vertex pos="3 3 -2" />
                            <Vertex pos="3 -3 -0.5" />
                            <Vertex pos="3 -3 -2" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 3" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 640 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 -1984 0 0 -1 -32 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -3" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 0.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="-4 1 13" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 1 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="2343" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 -9 8.5" />
                            <Vertex pos="1 1 8.5" />
                            <Vertex pos="1 1 12.5" />
                            <Vertex pos="1 -9 12.5" />
                            <Vertex pos="2 1 8.5" />
                            <Vertex pos="2 1 12.5" />
                            <Vertex pos="2 -9 12.5" />
                            <Vertex pos="2 -9 8.5" />
                        </Vertices>
                        <Face id="2336" plane="-1 0 0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2337" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="2338" plane="0 -1 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="2339" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="2340" plane="0 0 -1 8.5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="2341" plane="1 -4.76837e-008 1.19209e-007 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1.25 0 1216 0 0 -2 544 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="-4 1 13" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 1 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="2349" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 8.5" />
                            <Vertex pos="10 1 8.5" />
                            <Vertex pos="10 1 12.5" />
                            <Vertex pos="2 1 12.5" />
                            <Vertex pos="10 0 12.5" />
                            <Vertex pos="10 0 8.5" />
                            <Vertex pos="2 -2.38419e-007 12.5" />
                            <Vertex pos="2 -5.96046e-008 8.5" />
                        </Vertices>
                        <Face id="2342" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2343" plane="1 0 0 -10" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="2344" plane="0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="2345" plane="-0 -0 -1 8.5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="2346" plane="-1 0 1.19209e-007 2" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1.25 0 1216 0 0 -2 544 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="2347" plane="2.98023e-008 -1 -4.47035e-008 2.6077e-007" album="levelcreating" material="grid_multiplayer_wall" texgens="-1.25 0 0 288 0 0 -2 544 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="-4 1 13" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 1 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="2355" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -9 12.5" />
                            <Vertex pos="10 -9 12.5" />
                            <Vertex pos="10 -9 8.5" />
                            <Vertex pos="2 -9 8.5" />
                            <Vertex pos="10 -8 12.5" />
                            <Vertex pos="10 -8 8.5" />
                            <Vertex pos="2 -8 12.5" />
                            <Vertex pos="2 -8 8.5" />
                        </Vertices>
                        <Face id="2348" plane="-0 -1 -0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2349" plane="1 -0 0 -10" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="2350" plane="0 -0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="2351" plane="0 0 -1 8.5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="2352" plane="-1 -0 -1.19209e-007 2" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1.25 0 1216 0 0 -2 544 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="2353" plane="0 1 -0 8" album="levelcreating" material="grid_multiplayer_wall" texgens="1.25 0 0 96 0 0 -2 544 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="5 1 13" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 1 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="2343" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 -9 8.5" />
                            <Vertex pos="1 1 8.5" />
                            <Vertex pos="1 1 12.5" />
                            <Vertex pos="1 -9 12.5" />
                            <Vertex pos="2 1 8.5" />
                            <Vertex pos="2 1 12.5" />
                            <Vertex pos="2 -9 12.5" />
                            <Vertex pos="2 -9 8.5" />
                        </Vertices>
                        <Face id="2336" plane="-1 0 0 1" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="2337" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="2338" plane="0 -1 0 -9" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="2339" plane="-0 0 1 -12.5" album="levelcreating" material="grid_wavy2" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="2340" plane="0 0 -1 8.5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="2341" plane="1 -4.76837e-008 1.19209e-007 -2" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1.25 0 1216 0 0 -2 544 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="-13.5 11 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 11 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="16.5 1 12.5" />
                            <Vertex pos="16.5 1 12" />
                            <Vertex pos="16.5 -7 12.5" />
                            <Vertex pos="16.5 -7 12" />
                            <Vertex pos="14.5 1 12.5" />
                            <Vertex pos="14.5 1 12" />
                            <Vertex pos="14.5 -7 12.5" />
                            <Vertex pos="14.5 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -16.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 0 0 14.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 -1" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="-0 0 1 -12.5" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0 -1 12" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="-13.5 19 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 19 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="16.5 -5 13" />
                            <Vertex pos="16.5 -5 12.5" />
                            <Vertex pos="16.5 -7 12.5" />
                            <Vertex pos="16.5 -7 12" />
                            <Vertex pos="14.5 -5 13" />
                            <Vertex pos="14.5 -5 12.5" />
                            <Vertex pos="14.5 -7 12.5" />
                            <Vertex pos="14.5 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -16.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 -0 0 14.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="0 -0.242536 0.970143 -13.8245" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0.242536 -0.970143 13.3395" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="-13.5 21 1" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 21 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="16.5 -5 13.5" />
                            <Vertex pos="16.5 -5 13" />
                            <Vertex pos="16.5 -7 12.5" />
                            <Vertex pos="16.5 -7 12" />
                            <Vertex pos="14.5 -5 13.5" />
                            <Vertex pos="14.5 -5 13" />
                            <Vertex pos="14.5 -7 12.5" />
                            <Vertex pos="14.5 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -16.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 -0 0 14.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="0 -0.447214 0.894427 -14.3108" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0.447214 -0.894427 13.8636" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="-13.5 23 2" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 23 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="16.5 -5 14" />
                            <Vertex pos="16.5 -5 13.5" />
                            <Vertex pos="16.5 -7 12.5" />
                            <Vertex pos="16.5 -7 12" />
                            <Vertex pos="14.5 -5 14" />
                            <Vertex pos="14.5 -5 13.5" />
                            <Vertex pos="14.5 -7 12.5" />
                            <Vertex pos="14.5 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -16.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 -0 0 14.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="0 -0.6 0.8 -14.2" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0.6 -0.8 13.8" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="-13.5 25 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 25 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="2337" nextVertexID="3081">
                        <Vertices>
                            <Vertex pos="16.5 -5 14.5" />
                            <Vertex pos="16.5 -5 14" />
                            <Vertex pos="16.5 -7 12.5" />
                            <Vertex pos="16.5 -7 12" />
                            <Vertex pos="14.5 -5 14.5" />
                            <Vertex pos="14.5 -5 14" />
                            <Vertex pos="14.5 -7 12.5" />
                            <Vertex pos="14.5 -7 12" />
                        </Vertices>
                        <Face id="2330" plane="1 -0 0 -16.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 1 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2331" plane="-1 -0 0 14.5" album="levelcreating" material="grid_multiplayer_wall" texgens="0 -1 0 1280 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2332" plane="0 1 -0 5" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2333" plane="0 -1 0 -7" album="levelcreating" material="grid_multiplayer_wall" texgens="1 0 0 192 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2334" plane="0 -0.707107 0.707107 -13.7886" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2335" plane="0 0.707107 -0.707107 13.435" album="levelcreating" material="grid_multiplayer_wall" texgens="-1 0 0 192 0 -1 0 -192 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
