<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2014/08/22 18:20:59">
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
                <Brushes nextBrushID="163">
                    <Brush id="0" owner="0" type="0" pos="2.5 -5 2" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 -5 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 -5 6" />
                            <Vertex pos="4 -5 -6" />
                            <Vertex pos="-2 5 6" />
                            <Vertex pos="-2 5 -6" />
                            <Vertex pos="-2 -5 6" />
                            <Vertex pos="-2 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="2.5 -15 2" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 -15 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="0.5 -15 2" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -15 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-1.5 -15 2" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 -15 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="0.5 -17 2" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -17 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="2.5 -19 2" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 -19 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-1.5 -19 2" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 -19 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="2.5 -21 2" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 -21 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="0.5 -21 2" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -21 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-1.5 -21 2" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 -21 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="0.5 -23 2" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -23 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="2.5 -25 2" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 -25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-1.5 -25 2" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 -25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="0.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="2.5 -29 2" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 -29 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="-1.5 -29 2" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 -29 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="2.5 -31 2" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 -31 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="0.5 -31 2" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -31 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="-1.5 -31 2" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 -31 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="-3.5 -31 2" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -31 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="0.5 -33 2" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -33 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-3.5 -33 2" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -33 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="2.5 -35 2" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 -35 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-1.5 -35 2" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 -35 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-3.5 -35 2" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -35 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-5.5 -31 2" rot="1 0 0 0" scale="" transform="1 0 0 -5.5 0 1 0 -31 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 3 6" />
                            <Vertex pos="4 3 -6" />
                            <Vertex pos="2 5 6" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 3 6" />
                            <Vertex pos="2 3 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-13.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="10 1 6" />
                            <Vertex pos="10 1 -6" />
                            <Vertex pos="10 -5 6" />
                            <Vertex pos="10 -5 -6" />
                            <Vertex pos="-4 1 6" />
                            <Vertex pos="-4 1 -6" />
                            <Vertex pos="-4 -5 6" />
                            <Vertex pos="-4 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -10" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-15.5 -21 2" rot="1 0 0 0" scale="" transform="1 0 0 -15.5 0 1 0 -21 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 -5 6" />
                            <Vertex pos="4 -5 -6" />
                            <Vertex pos="-2 5 6" />
                            <Vertex pos="-2 5 -6" />
                            <Vertex pos="-2 -5 6" />
                            <Vertex pos="-2 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -6" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-15.5 -11 2" rot="1 0 0 0" scale="" transform="1 0 0 -15.5 0 1 0 -11 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 10" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 -5 10" />
                            <Vertex pos="4 -5 -6" />
                            <Vertex pos="-2 5 10" />
                            <Vertex pos="-2 5 -6" />
                            <Vertex pos="-2 -5 10" />
                            <Vertex pos="-2 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="pattern_cool2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-15.5 -1 2" rot="1 0 0 0" scale="" transform="1 0 0 -15.5 0 1 0 -1 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 1 10" />
                            <Vertex pos="4 1 -6" />
                            <Vertex pos="4 -5 10" />
                            <Vertex pos="4 -5 -6" />
                            <Vertex pos="-2 1 10" />
                            <Vertex pos="-2 1 -6" />
                            <Vertex pos="-2 -5 10" />
                            <Vertex pos="-2 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-9.5 -1 2" rot="1 0 0 0" scale="" transform="1 0 0 -9.5 0 1 0 -1 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="8 1 10" />
                            <Vertex pos="8 1 -6" />
                            <Vertex pos="8 -5 10" />
                            <Vertex pos="8 -5 -6" />
                            <Vertex pos="-2 1 10" />
                            <Vertex pos="-2 1 -6" />
                            <Vertex pos="-2 -5 10" />
                            <Vertex pos="-2 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -8" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="0.5 -1 2" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -1 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="0 1 10" />
                            <Vertex pos="0 1 -6" />
                            <Vertex pos="0 -5 10" />
                            <Vertex pos="0 -5 -6" />
                            <Vertex pos="-2 1 10" />
                            <Vertex pos="-2 1 -6" />
                            <Vertex pos="-2 -5 10" />
                            <Vertex pos="-2 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -0" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -10" album="levelcreating" material="pattern_cool1" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="8.5 -1 2" rot="1 0 0 0" scale="" transform="1 0 0 8.5 0 1 0 -1 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="8 1 10" />
                            <Vertex pos="8 1 -6" />
                            <Vertex pos="8 -5 10" />
                            <Vertex pos="8 -5 -6" />
                            <Vertex pos="-2 1 10" />
                            <Vertex pos="-2 1 -6" />
                            <Vertex pos="-2 -5 10" />
                            <Vertex pos="-2 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -8" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="12.5 -11 2" rot="1 0 0 0" scale="" transform="1 0 0 12.5 0 1 0 -11 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 10" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 -11 10" />
                            <Vertex pos="4 -11 -6" />
                            <Vertex pos="-2 5 10" />
                            <Vertex pos="-2 5 -6" />
                            <Vertex pos="-2 -11 10" />
                            <Vertex pos="-2 -11 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -11" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="12.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 12.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 5 10" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 -11 10" />
                            <Vertex pos="4 -11 -6" />
                            <Vertex pos="-2 5 10" />
                            <Vertex pos="-2 5 -6" />
                            <Vertex pos="-2 -11 10" />
                            <Vertex pos="-2 -11 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -11" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -10" album="levelcreating" material="friction_none" texgens="1 0 0 456 0 -1 0 112 0 0.4 0.4" texRot="0" texScale="0.4 0.4" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="6.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 6.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="4 -5 10" />
                            <Vertex pos="4 -5 -6" />
                            <Vertex pos="4 -11 10" />
                            <Vertex pos="4 -11 -6" />
                            <Vertex pos="-8 -5 10" />
                            <Vertex pos="-8 -5 -6" />
                            <Vertex pos="-8 -11 10" />
                            <Vertex pos="-8 -11 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -8" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 5" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -11" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -10" album="levelcreating" material="friction_none" texgens="1 0 0 456 0 -1 0 112 0 0.4 0.4" texRot="0" texScale="0.4 0.4" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="-9.5 -33 2" rot="1 0 0 0" scale="" transform="1 0 0 -9.5 0 1 0 -33 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="8 1 10" />
                            <Vertex pos="8 1 -6" />
                            <Vertex pos="8 -5 10" />
                            <Vertex pos="8 -5 -6" />
                            <Vertex pos="0 1 10" />
                            <Vertex pos="0 1 -6" />
                            <Vertex pos="0 -5 10" />
                            <Vertex pos="0 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -8" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -0" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -10" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="-19.5 -33 2" rot="1 0 0 0" scale="" transform="1 0 0 -19.5 0 1 0 -33 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="8 1 16" />
                            <Vertex pos="8 1 -6" />
                            <Vertex pos="8 -5 16" />
                            <Vertex pos="8 -5 -6" />
                            <Vertex pos="-4 1 16" />
                            <Vertex pos="-4 1 -6" />
                            <Vertex pos="-4 -5 16" />
                            <Vertex pos="-4 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -8" album="levelcreating" material="friction_high" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="-17.5 -33 2" rot="1 0 0 0" scale="" transform="1 0 0 -17.5 0 1 0 -33 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="8 1 10" />
                            <Vertex pos="8 1 -6" />
                            <Vertex pos="8 -5 10" />
                            <Vertex pos="8 -5 -6" />
                            <Vertex pos="6 1 10" />
                            <Vertex pos="6 1 -6" />
                            <Vertex pos="6 -5 10" />
                            <Vertex pos="6 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -8" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 6" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -10" album="levelcreating" material="pattern_cool1" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="-19.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 -19.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="2 21 16" />
                            <Vertex pos="2 21 -6" />
                            <Vertex pos="2 -5 16" />
                            <Vertex pos="2 -5 -6" />
                            <Vertex pos="-4 21 16" />
                            <Vertex pos="-4 21 -6" />
                            <Vertex pos="-4 -5 16" />
                            <Vertex pos="-4 -5 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -21" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -5" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="-13.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 16" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 16" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 16" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 16" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="-11.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 22" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 22" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 22" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 22" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -22" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="-11.5 -27 10" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 -27 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 16" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 16" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-16 -1 16" />
                            <Vertex pos="-16 -1 14" />
                            <Vertex pos="-16 -3 16" />
                            <Vertex pos="-16 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -16" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="-21.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 16" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 16" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 16" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 16" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="-23.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 22" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 22" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 22" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 22" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -22" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="-13.5 -21 2" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 -21 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 16" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 16" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 16" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 16" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="-11.5 -21 2" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 -21 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 22" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 22" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 22" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 22" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -22" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="-11.5 -21 10" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 -21 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 16" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 16" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-16 -1 16" />
                            <Vertex pos="-16 -1 14" />
                            <Vertex pos="-16 -3 16" />
                            <Vertex pos="-16 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -16" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="-21.5 -21 2" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -21 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 16" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 16" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 16" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 16" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="-23.5 -21 2" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 -21 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 22" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 22" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 22" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 22" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -22" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="-13.5 -15 2" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 -15 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 16" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 16" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 16" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 16" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="-11.5 -15 2" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 -15 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 22" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 22" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 22" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 22" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -22" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="-11.5 -15 10" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 -15 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 16" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 16" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-16 -1 16" />
                            <Vertex pos="-16 -1 14" />
                            <Vertex pos="-16 -3 16" />
                            <Vertex pos="-16 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -16" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="-21.5 -15 2" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -15 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 16" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 16" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 16" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 16" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="-23.5 -15 2" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 -15 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 -1 22" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -3 22" />
                            <Vertex pos="-2 -3 14" />
                            <Vertex pos="-4 -1 22" />
                            <Vertex pos="-4 -1 14" />
                            <Vertex pos="-4 -3 22" />
                            <Vertex pos="-4 -3 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 1" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -22" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="-7.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="0 21 16" />
                            <Vertex pos="0 21 -6" />
                            <Vertex pos="0 15 16" />
                            <Vertex pos="0 15 -6" />
                            <Vertex pos="-4 21 16" />
                            <Vertex pos="-4 21 -6" />
                            <Vertex pos="-4 15 16" />
                            <Vertex pos="-4 15 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -0" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -21" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 15" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="-13.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 -13.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="2 21 16" />
                            <Vertex pos="2 21 14" />
                            <Vertex pos="2 15 16" />
                            <Vertex pos="2 15 14" />
                            <Vertex pos="-4 21 16" />
                            <Vertex pos="-4 21 14" />
                            <Vertex pos="-4 15 16" />
                            <Vertex pos="-4 15 14" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -21" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 15" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 14" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="-3.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="-2 21 16" />
                            <Vertex pos="-2 21 -6" />
                            <Vertex pos="-2 15 16" />
                            <Vertex pos="-2 15 -6" />
                            <Vertex pos="-4 21 16" />
                            <Vertex pos="-4 21 -6" />
                            <Vertex pos="-4 15 16" />
                            <Vertex pos="-4 15 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -21" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 15" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -16" album="levelcreating" material="pattern_cool1" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="0.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="0 21 22" />
                            <Vertex pos="0 21 -6" />
                            <Vertex pos="0 15 22" />
                            <Vertex pos="0 15 -6" />
                            <Vertex pos="-6 21 22" />
                            <Vertex pos="-6 21 -6" />
                            <Vertex pos="-6 15 22" />
                            <Vertex pos="-6 15 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -0" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -6" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -21" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 15" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -22" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="10.5 -27 2" rot="1 0 0 0" scale="" transform="1 0 0 10.5 0 1 0 -27 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="0 21 18" />
                            <Vertex pos="0 21 -6" />
                            <Vertex pos="0 15 18" />
                            <Vertex pos="0 15 -6" />
                            <Vertex pos="-4 21 18" />
                            <Vertex pos="-4 21 -6" />
                            <Vertex pos="-4 15 18" />
                            <Vertex pos="-4 15 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -0" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -21" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 15" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -18" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="10.5 -27 26" rot="1 0 0 0" scale="" transform="1 0 0 10.5 0 1 0 -27 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="0 21 -2" />
                            <Vertex pos="0 21 -6" />
                            <Vertex pos="0 15 -2" />
                            <Vertex pos="0 15 -6" />
                            <Vertex pos="-4 21 -2" />
                            <Vertex pos="-4 21 -6" />
                            <Vertex pos="-4 15 -2" />
                            <Vertex pos="-4 15 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -0" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="pattern_cool2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -21" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 15" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 2" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="14.5 -35 2" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 -35 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="0 21 22" />
                            <Vertex pos="0 21 -6" />
                            <Vertex pos="0 19 22" />
                            <Vertex pos="0 19 -6" />
                            <Vertex pos="-2 21 22" />
                            <Vertex pos="-2 21 -6" />
                            <Vertex pos="-2 19 22" />
                            <Vertex pos="-2 19 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -0" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -21" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 19" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -22" album="levelcreating" material="pattern_neutral1" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="14.5 -35 30" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 -35 0 0 1 30 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="0 21 -4" />
                            <Vertex pos="0 21 -6" />
                            <Vertex pos="0 19 -4" />
                            <Vertex pos="0 19 -6" />
                            <Vertex pos="-2 21 -4" />
                            <Vertex pos="-2 21 -6" />
                            <Vertex pos="-2 19 -4" />
                            <Vertex pos="-2 19 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -0" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -21" album="levelcreating" material="pattern_cool2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 19" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 4" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="14.5 -37 30" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 -37 0 0 1 30 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="2 21 -4" />
                            <Vertex pos="2 21 -6" />
                            <Vertex pos="2 -1 -4" />
                            <Vertex pos="2 -1 -6" />
                            <Vertex pos="-4 21 -4" />
                            <Vertex pos="-4 21 -6" />
                            <Vertex pos="-4 -1 -4" />
                            <Vertex pos="-4 -1 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -21" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -1" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 4" album="levelcreating" material="grid_wavy2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="14.5 -37 32" rot="1 0 0 0" scale="" transform="1 0 0 14.5 0 1 0 -37 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="2 1 8" />
                            <Vertex pos="2 1 -6" />
                            <Vertex pos="2 -1 8" />
                            <Vertex pos="2 -1 -6" />
                            <Vertex pos="-4 1 8" />
                            <Vertex pos="-4 1 -6" />
                            <Vertex pos="-4 -1 8" />
                            <Vertex pos="-4 -1 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -1" album="levelcreating" material="grid_wavy2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -1" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -8" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="8.5 -37 32" rot="1 0 0 0" scale="" transform="1 0 0 8.5 0 1 0 -37 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="2 1 8" />
                            <Vertex pos="2 1 2" />
                            <Vertex pos="2 -1 8" />
                            <Vertex pos="2 -1 2" />
                            <Vertex pos="-14 1 8" />
                            <Vertex pos="-14 1 2" />
                            <Vertex pos="-14 -1 8" />
                            <Vertex pos="-14 -1 2" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -14" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -1" album="levelcreating" material="grid_wavy2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -1" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -8" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 2" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-7.5 -37 32" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -37 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="2 1 8" />
                            <Vertex pos="2 1 -6" />
                            <Vertex pos="2 -1 8" />
                            <Vertex pos="2 -1 -6" />
                            <Vertex pos="-4 1 8" />
                            <Vertex pos="-4 1 -6" />
                            <Vertex pos="-4 -1 8" />
                            <Vertex pos="-4 -1 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -1" album="levelcreating" material="grid_wavy2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -1" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 -8" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="-7.5 -35 32" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -35 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="2 5 -4" />
                            <Vertex pos="2 5 -6" />
                            <Vertex pos="2 -1 -4" />
                            <Vertex pos="2 -1 -6" />
                            <Vertex pos="-4 5 -4" />
                            <Vertex pos="-4 5 -6" />
                            <Vertex pos="-4 -1 -4" />
                            <Vertex pos="-4 -1 -6" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="grid_wavy2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 -1" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 4" album="levelcreating" material="pattern_cool2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -6" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="-7.5 -35 30" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 -35 0 0 1 30 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="2 5 -4" />
                            <Vertex pos="2 5 -8" />
                            <Vertex pos="2 3 -4" />
                            <Vertex pos="2 3 -8" />
                            <Vertex pos="-4 5 -4" />
                            <Vertex pos="-4 5 -8" />
                            <Vertex pos="-4 3 -4" />
                            <Vertex pos="-4 3 -8" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="grid_wavy2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 4" album="levelcreating" material="pattern_cool2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -8" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="-1.5 -35 30" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 -35 0 0 1 30 0 0 0 1" group="-1" locked="0" nextFaceID="2779" nextVertexID="3705">
                        <Vertices>
                            <Vertex pos="2 5 -2" />
                            <Vertex pos="2 5 -8" />
                            <Vertex pos="2 3 -2" />
                            <Vertex pos="2 3 -8" />
                            <Vertex pos="-4 5 -2" />
                            <Vertex pos="-4 5 -8" />
                            <Vertex pos="-4 3 -2" />
                            <Vertex pos="-4 3 -8" />
                        </Vertices>
                        <Face id="2772" plane="1 -0 0 -2" album="levelcreating" material="mbs_wall2" texgens="0 1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="2773" plane="-1 0 0 -4" album="levelcreating" material="mbs_wall2" texgens="0 -1 0 320 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2774" plane="0 1 -0 -5" album="levelcreating" material="grid_wavy2" texgens="-1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2775" plane="0 -1 0 3" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="2776" plane="-0 0 1 2" album="levelcreating" material="mbs_wall2" texgens="1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="2777" plane="0 0 -1 -8" album="levelcreating" material="mbs_wall2" texgens="-1 0 0 256 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
