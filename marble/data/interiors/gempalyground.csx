<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2014/06/19 11:31:31">
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
                <Brushes nextBrushID="83">
                    <Brush id="0" owner="0" type="0" pos="5.25 -4.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 -4.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="3.25 -0.75 2" />
                            <Vertex pos="3.25 -0.75 -2" />
                            <Vertex pos="3.25 -4.75 2" />
                            <Vertex pos="3.25 -4.75 -2" />
                            <Vertex pos="-8.75 -0.75 2" />
                            <Vertex pos="-8.75 -0.75 -2" />
                            <Vertex pos="-8.75 -4.75 2" />
                            <Vertex pos="-8.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -3.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -8.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_wavy2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="5.25 -0.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 -0.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -2" />
                            <Vertex pos="-0.75 -4.75 2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -0.75 2" />
                            <Vertex pos="-4.75 -0.75 -2" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_wavy2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="5.25 3.25 9.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 3.25 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="3.25 -2.75 0" />
                            <Vertex pos="3.25 -2.75 -2" />
                            <Vertex pos="3.25 -4.75 0" />
                            <Vertex pos="3.25 -4.75 -2" />
                            <Vertex pos="-0.75 -2.75 -2" />
                            <Vertex pos="-0.75 -2.75 -2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -3.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0.447214 0 0.894427 1.45344" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="13.25 3.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 3.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-2.75 -2.75 4" />
                            <Vertex pos="-2.75 -2.75 -2" />
                            <Vertex pos="-2.75 -4.75 4" />
                            <Vertex pos="-2.75 -4.75 -2" />
                            <Vertex pos="-4.75 -2.75 4" />
                            <Vertex pos="-4.75 -2.75 -2" />
                            <Vertex pos="-4.75 -4.75 4" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 2.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -4" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="13.25 5.25 8" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 5.25 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-2.75 -0.75 4" />
                            <Vertex pos="-2.75 -0.75 -4.5" />
                            <Vertex pos="-2.75 -4.75 1.5" />
                            <Vertex pos="-2.75 -4.75 -4.5" />
                            <Vertex pos="-4.75 -0.75 4" />
                            <Vertex pos="-4.75 -0.75 -4.5" />
                            <Vertex pos="-4.75 -4.75 1.5" />
                            <Vertex pos="-4.75 -4.75 -4.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 2.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0 -0.529999 0.847998 -3.78949" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -4.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="11.25 9.25 10" rot="1 0 0 0" scale="" transform="1 0 0 11.25 0 1 0 9.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 1.25 2" />
                            <Vertex pos="1.25 1.25 -4.5" />
                            <Vertex pos="1.25 -4.75 2" />
                            <Vertex pos="1.25 -4.75 -4.5" />
                            <Vertex pos="-4.75 1.25 2" />
                            <Vertex pos="-4.75 1.25 -4.5" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -4.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -4.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="7.25 3.25 10" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 3.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 1.25 2" />
                            <Vertex pos="1.25 1.25 -2.5" />
                            <Vertex pos="1.25 -0.75 3" />
                            <Vertex pos="1.25 -0.75 -2.5" />
                            <Vertex pos="-0.75 1.25 2" />
                            <Vertex pos="-0.75 1.25 -2.5" />
                            <Vertex pos="-0.75 -0.75 3" />
                            <Vertex pos="-0.75 -0.75 -2.5" />
                        </Vertices>
                        <Face id="1044" plane="1 0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0.447214 0.894427 -2.34787" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="5.25 3.25 10" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 3.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1058" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 1.25 2" />
                            <Vertex pos="1.25 1.25 -6" />
                            <Vertex pos="1.25 -0.75 3" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="1.25 1.25 2" />
                            <Vertex pos="1.25 1.25 -6" />
                            <Vertex pos="-0.75 -0.75 3" />
                            <Vertex pos="-0.75 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-0.707107 0.707107 0 -0" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1056" plane="0 0.447214 0.894427 -2.34787" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="5.25 3.25 10" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 3.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1058" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 1.25 2" />
                            <Vertex pos="1.25 1.25 -2.5" />
                            <Vertex pos="1.25 1.25 2" />
                            <Vertex pos="1.25 1.25 -2.5" />
                            <Vertex pos="-0.75 1.25 3" />
                            <Vertex pos="-0.75 1.25 -2.5" />
                            <Vertex pos="-0.75 -0.75 3" />
                            <Vertex pos="-0.75 -0.75 -2.5" />
                        </Vertices>
                        <Face id="1044" plane="1 0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0.707107 -0.707107 0 -0" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1056" plane="0.447214 0 0.894427 -2.34787" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="5.25 5.25 10" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 5.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 1.25 2" />
                            <Vertex pos="1.25 1.25 -2.5" />
                            <Vertex pos="1.25 -0.75 2" />
                            <Vertex pos="1.25 -0.75 -2.5" />
                            <Vertex pos="-0.75 1.25 3" />
                            <Vertex pos="-0.75 1.25 -2.5" />
                            <Vertex pos="-0.75 -0.75 3" />
                            <Vertex pos="-0.75 -0.75 -2.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0.447214 0 0.894427 -2.34787" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="13.25 11.25 10" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 11.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 1.25 3" />
                            <Vertex pos="1.25 1.25 -6" />
                            <Vertex pos="1.25 -0.75 3" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -6" />
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="-0.707107 0.707107 0 -0" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0.447214 0 0.894427 -2.12426" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="5.25 9.25 10" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 9.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 1.25 2" />
                            <Vertex pos="1.25 1.25 -6" />
                            <Vertex pos="1.25 -0.75 2" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="-0.75 1.25 3" />
                            <Vertex pos="-0.75 1.25 -6" />
                            <Vertex pos="-0.75 -0.75 3" />
                            <Vertex pos="-0.75 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0.447214 0 0.894427 -2.34787" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="5.25 11.25 10" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 11.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 -0.75 2" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="1.25 -0.75 2" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="-0.75 1.25 3" />
                            <Vertex pos="-0.75 1.25 -6" />
                            <Vertex pos="-0.75 -0.75 3" />
                            <Vertex pos="-0.75 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0.707107 0.707107 -0 -0.353553" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0.447214 0 0.894427 -2.34787" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="5.25 11.25 10" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 11.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 1.25 3" />
                            <Vertex pos="1.25 1.25 -6" />
                            <Vertex pos="1.25 -0.75 2" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="-0.75 1.25 3" />
                            <Vertex pos="-0.75 1.25 -6" />
                            <Vertex pos="1.25 -0.75 2" />
                            <Vertex pos="1.25 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-0.707107 -0.707107 0 0.353553" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0 -0.447214 0.894427 -2.12426" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="-0 -0 -1 -6" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="7.25 11.25 10" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 11.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="5.25 1.25 3" />
                            <Vertex pos="5.25 1.25 -6" />
                            <Vertex pos="5.25 -0.75 2" />
                            <Vertex pos="5.25 -0.75 -6" />
                            <Vertex pos="-0.75 1.25 3" />
                            <Vertex pos="-0.75 1.25 -6" />
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -5.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0 -0.447214 0.894427 -2.12426" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="13.25 11.25 10" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 11.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1065" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 1.25 3" />
                            <Vertex pos="1.25 1.25 -6" />
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -6" />
                            <Vertex pos="-0.75 1.25 3" />
                            <Vertex pos="-0.75 1.25 -6" />
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -6" />
                        </Vertices>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0 -0.447214 0.894427 -2.12426" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1063" plane="0.707107 -0.707107 0 -0" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="5.25 7.25 10" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 7.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 1.25 2" />
                            <Vertex pos="1.25 1.25 -2.5" />
                            <Vertex pos="1.25 -0.75 2" />
                            <Vertex pos="1.25 -0.75 -2.5" />
                            <Vertex pos="-0.75 1.25 3" />
                            <Vertex pos="-0.75 1.25 -2.5" />
                            <Vertex pos="-0.75 -0.75 3" />
                            <Vertex pos="-0.75 -0.75 -2.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0.447214 0 0.894427 -2.34787" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="11.25 3.25 10" rot="1 0 0 0" scale="" transform="1 0 0 11.25 0 1 0 3.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 1.25 2" />
                            <Vertex pos="1.25 1.25 -6" />
                            <Vertex pos="1.25 -0.75 3" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="-0.75 1.25 2" />
                            <Vertex pos="-0.75 1.25 -6" />
                            <Vertex pos="-0.75 -0.75 3" />
                            <Vertex pos="-0.75 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0.447214 0.894427 -2.34787" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="13.25 5.25 10" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 5.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 5.25 3" />
                            <Vertex pos="1.25 5.25 -6" />
                            <Vertex pos="1.25 -0.75 3" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="-0.75 5.25 2" />
                            <Vertex pos="-0.75 5.25 -6" />
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -5.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0.447214 0 0.894427 -2.12426" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="13.25 3.25 10" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 3.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1058" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 1.25 2" />
                            <Vertex pos="-0.75 1.25 -6" />
                            <Vertex pos="1.25 -0.75 3" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="-0.75 1.25 2" />
                            <Vertex pos="-0.75 1.25 -6" />
                            <Vertex pos="-0.75 -0.75 3" />
                            <Vertex pos="-0.75 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="0.707107 0.707107 0 -0.353553" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1056" plane="0 0.447214 0.894427 -2.34787" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="13.25 -0.75 10" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 -0.75 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1058" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 5.25 3" />
                            <Vertex pos="1.25 5.25 -2.5" />
                            <Vertex pos="1.25 3.25 3" />
                            <Vertex pos="1.25 3.25 -2.5" />
                            <Vertex pos="-0.75 5.25 2" />
                            <Vertex pos="-0.75 5.25 -2.5" />
                            <Vertex pos="-0.75 5.25 2" />
                            <Vertex pos="-0.75 5.25 -2.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -0.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -5.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="-0.707107 -0.707107 -0 3.18198" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1056" plane="-0.447214 0 0.894427 -2.12426" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="1.25 3.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 1.25 0 1 0 3.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -0.75 3.5" />
                            <Vertex pos="-0.75 -0.75 -2" />
                            <Vertex pos="-0.75 -4.75 2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -0.75 3.5" />
                            <Vertex pos="-4.75 -0.75 -2" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0 -0.351123 0.936329 -3.54049" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="9.25 3.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 9.25 0 1 0 3.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -2" />
                            <Vertex pos="-0.75 -4.75 2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -0.75 2" />
                            <Vertex pos="-4.75 -0.75 -2" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_wavy2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="5.25 3.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 3.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -2" />
                            <Vertex pos="-0.75 -4.75 2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -0.75 2" />
                            <Vertex pos="-4.75 -0.75 -2" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_wavy2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-2.75 3.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 3.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -2" />
                            <Vertex pos="-0.75 -4.75 4" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -0.75 2" />
                            <Vertex pos="-4.75 -0.75 -2" />
                            <Vertex pos="-4.75 -4.75 4" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0.447214 0.894427 -1.45344" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-6.75 3.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 3.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -0.75 3.5" />
                            <Vertex pos="-0.75 -0.75 -2" />
                            <Vertex pos="-0.75 -4.75 2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -0.75 3.5" />
                            <Vertex pos="-4.75 -0.75 -2" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0 -0.351123 0.936329 -3.54049" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-10.75 3.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -10.75 0 1 0 3.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -2" />
                            <Vertex pos="-0.75 -4.75 4" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -0.75 2" />
                            <Vertex pos="-4.75 -0.75 -2" />
                            <Vertex pos="-4.75 -4.75 4" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0.447214 0.894427 -1.45344" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-14.75 3.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 3.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -2" />
                            <Vertex pos="-0.75 -4.75 2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -0.75 2" />
                            <Vertex pos="-4.75 -0.75 -2" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_wavy2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-14.75 7.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 7.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -2" />
                            <Vertex pos="-0.75 -4.75 2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -0.75 2" />
                            <Vertex pos="-4.75 -0.75 -2" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_wavy2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-14.75 11.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 11.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -4.25 2" />
                            <Vertex pos="-0.75 -4.25 -2" />
                            <Vertex pos="-0.75 -4.75 2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -4.25 2" />
                            <Vertex pos="-4.75 -4.25 -2" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 4.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="stripe_caution" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-14.75 11.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 11.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 5.25 2" />
                            <Vertex pos="-0.75 5.25 -2" />
                            <Vertex pos="-0.75 -4.75 2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 5.25 2" />
                            <Vertex pos="-4.75 5.25 -2" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -5.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-14.75 21.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 21.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -4.25 2" />
                            <Vertex pos="-0.75 -4.25 -2" />
                            <Vertex pos="-0.75 -4.75 2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -4.25 2" />
                            <Vertex pos="-4.75 -4.25 -2" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 4.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="stripe_caution" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-14.75 22.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 22.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-0.75 -0.75 2" />
                            <Vertex pos="-0.75 -0.75 -2" />
                            <Vertex pos="-0.75 -4.75 2" />
                            <Vertex pos="-0.75 -4.75 -2" />
                            <Vertex pos="-4.75 -0.75 2" />
                            <Vertex pos="-4.75 -0.75 -2" />
                            <Vertex pos="-4.75 -4.75 2" />
                            <Vertex pos="-4.75 -4.75 -2" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 0.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 0.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -4.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_wavy2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -2" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="9.25 9.25 2.5" rot="1 0 0 0" scale="" transform="1 0 0 9.25 0 1 0 9.25 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="5.25 1.25 2" />
                            <Vertex pos="5.25 1.25 1.5" />
                            <Vertex pos="5.25 -6.75 2" />
                            <Vertex pos="5.25 -6.75 1.5" />
                            <Vertex pos="-4.75 1.25 2" />
                            <Vertex pos="-4.75 1.25 1.5" />
                            <Vertex pos="-4.75 -6.75 2" />
                            <Vertex pos="-4.75 -6.75 1.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -5.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -4.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -1.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -6.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_wavy2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 1.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="10.25 3.25 19" rot="1 0 0 0" scale="" transform="1 0 0 10.25 0 1 0 3.25 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 -5" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 -5" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 -5" />
                            <Vertex pos="0.25 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="-0 -0.447214 -0.894427 -5.70197" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="7.25 3.25 19" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 3.25 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 -5" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 -5" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 -5" />
                            <Vertex pos="0.25 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="-0 -0.447214 -0.894427 -5.70197" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="4.25 3.25 19" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 3.25 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 2" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 2" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 2" />
                            <Vertex pos="0.25 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="-0 -0.447214 -0.894427 -5.70197" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="4.25 12.25 19" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 12.25 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 2" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 2" />
                            <Vertex pos="1.25 -0.75 -7" />
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 2" />
                            <Vertex pos="0.25 -0.75 -7" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 -0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0.447214 -0.894427 -5.92558" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="13.25 12.25 19" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 12.25 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 2" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 2" />
                            <Vertex pos="1.25 -0.75 -7" />
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 2" />
                            <Vertex pos="0.25 -0.75 -7" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 -0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0.447214 -0.894427 -5.92558" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="13.25 3.25 19" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 3.25 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 2" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 2" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 2" />
                            <Vertex pos="0.25 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 -2" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="-0 -0.447214 -0.894427 -5.70197" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="4.25 8.75 20.5" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 8.75 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 2.75 -5.5" />
                            <Vertex pos="1.25 2.75 -6.5" />
                            <Vertex pos="1.25 -5.25 -5.5" />
                            <Vertex pos="1.25 -5.25 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 -5.25 -5.5" />
                            <Vertex pos="0.25 -5.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -5.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="4.25 8.75 22.5" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 8.75 0 0 1 22.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 2.75 -5.5" />
                            <Vertex pos="1.25 2.75 -6.5" />
                            <Vertex pos="1.25 -5.25 -5.5" />
                            <Vertex pos="1.25 -5.25 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 -5.25 -5.5" />
                            <Vertex pos="0.25 -5.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -5.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="4.25 8.75 24.5" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 8.75 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 2.75 -5.5" />
                            <Vertex pos="1.25 2.75 -6.5" />
                            <Vertex pos="1.25 -5.25 -5.5" />
                            <Vertex pos="1.25 -5.25 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 -5.25 -5.5" />
                            <Vertex pos="0.25 -5.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -5.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="4.25 8.75 26.5" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 8.75 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 2.75 -5.5" />
                            <Vertex pos="1.25 2.75 -6.5" />
                            <Vertex pos="1.25 -5.25 -5.5" />
                            <Vertex pos="1.25 -5.25 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 -5.25 -5.5" />
                            <Vertex pos="0.25 -5.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -5.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="13.25 8.75 20.5" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 8.75 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 2.75 -5.5" />
                            <Vertex pos="1.25 2.75 -6.5" />
                            <Vertex pos="1.25 -5.25 -5.5" />
                            <Vertex pos="1.25 -5.25 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 -5.25 -5.5" />
                            <Vertex pos="0.25 -5.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -5.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="13.25 8.75 22.5" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 8.75 0 0 1 22.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 2.75 -5.5" />
                            <Vertex pos="1.25 2.75 -6.5" />
                            <Vertex pos="1.25 -5.25 -5.5" />
                            <Vertex pos="1.25 -5.25 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 -5.25 -5.5" />
                            <Vertex pos="0.25 -5.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -5.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="13.25 8.75 24.5" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 8.75 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 2.75 -5.5" />
                            <Vertex pos="1.25 2.75 -6.5" />
                            <Vertex pos="1.25 -5.25 -5.5" />
                            <Vertex pos="1.25 -5.25 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 -5.25 -5.5" />
                            <Vertex pos="0.25 -5.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -5.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="13.25 8.75 26.5" rot="1 0 0 0" scale="" transform="1 0 0 13.25 0 1 0 8.75 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 2.75 -5.5" />
                            <Vertex pos="1.25 2.75 -6.5" />
                            <Vertex pos="1.25 -5.25 -5.5" />
                            <Vertex pos="1.25 -5.25 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 -5.25 -5.5" />
                            <Vertex pos="0.25 -5.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -5.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="5.25 0.75 26.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 0.75 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="8.25 2.75 -5.5" />
                            <Vertex pos="8.25 2.75 -6.5" />
                            <Vertex pos="8.25 1.75 -5.5" />
                            <Vertex pos="8.25 1.75 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 1.75 -5.5" />
                            <Vertex pos="0.25 1.75 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -8.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 1.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="5.25 0.75 24.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 0.75 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="8.25 2.75 -5.5" />
                            <Vertex pos="8.25 2.75 -6.5" />
                            <Vertex pos="8.25 1.75 -5.5" />
                            <Vertex pos="8.25 1.75 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 1.75 -5.5" />
                            <Vertex pos="0.25 1.75 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -8.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 1.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="5.25 0.75 22.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 0.75 0 0 1 22.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="8.25 2.75 -5.5" />
                            <Vertex pos="8.25 2.75 -6.5" />
                            <Vertex pos="8.25 1.75 -5.5" />
                            <Vertex pos="8.25 1.75 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 1.75 -5.5" />
                            <Vertex pos="0.25 1.75 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -8.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 1.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="5.25 0.75 20.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 0.75 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="8.25 2.75 -5.5" />
                            <Vertex pos="8.25 2.75 -6.5" />
                            <Vertex pos="8.25 1.75 -5.5" />
                            <Vertex pos="8.25 1.75 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 1.75 -5.5" />
                            <Vertex pos="0.25 1.75 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -8.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 1.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="10.25 3.25 21" rot="1 0 0 0" scale="" transform="1 0 0 10.25 0 1 0 3.25 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 -5" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 -5" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 -5" />
                            <Vertex pos="0.25 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="-0 -0.447214 -0.894427 -5.70197" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="7.25 3.25 21" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 3.25 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 -5" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 -5" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 -5" />
                            <Vertex pos="0.25 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="-0 -0.447214 -0.894427 -5.70197" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="10.25 3.25 23" rot="1 0 0 0" scale="" transform="1 0 0 10.25 0 1 0 3.25 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 -5" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 -5" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 -5" />
                            <Vertex pos="0.25 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="-0 -0.447214 -0.894427 -5.70197" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="7.25 3.25 23" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 3.25 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 -5" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 -5" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 -5" />
                            <Vertex pos="0.25 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="-0 -0.447214 -0.894427 -5.70197" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="10.25 3.25 25" rot="1 0 0 0" scale="" transform="1 0 0 10.25 0 1 0 3.25 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 -5" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 -5" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 -5" />
                            <Vertex pos="0.25 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="-0 -0.447214 -0.894427 -5.70197" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="7.25 3.25 25" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 3.25 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="1.25 0.25 -5" />
                            <Vertex pos="1.25 0.25 -6.5" />
                            <Vertex pos="1.25 -0.75 -5" />
                            <Vertex pos="1.25 -0.75 -6" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 0.25 -6.5" />
                            <Vertex pos="0.25 -0.75 -5" />
                            <Vertex pos="0.25 -0.75 -6" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -1.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -0.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -0.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5" album="mbs" material="grid_Wavy5" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="-0 -0.447214 -0.894427 -5.70197" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="5.25 9.75 24.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 9.75 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="8.25 2.75 -5.5" />
                            <Vertex pos="8.25 2.75 -6.5" />
                            <Vertex pos="8.25 1.75 -5.5" />
                            <Vertex pos="8.25 1.75 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 1.75 -5.5" />
                            <Vertex pos="0.25 1.75 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -8.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 1.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="5.25 9.75 22.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 9.75 0 0 1 22.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="8.25 2.75 -5.5" />
                            <Vertex pos="8.25 2.75 -6.5" />
                            <Vertex pos="8.25 1.75 -5.5" />
                            <Vertex pos="8.25 1.75 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 1.75 -5.5" />
                            <Vertex pos="0.25 1.75 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -8.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 1.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="5.25 9.75 20.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 9.75 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="8.25 2.75 -5.5" />
                            <Vertex pos="8.25 2.75 -6.5" />
                            <Vertex pos="8.25 1.75 -5.5" />
                            <Vertex pos="8.25 1.75 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 1.75 -5.5" />
                            <Vertex pos="0.25 1.75 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -8.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 1.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="5.25 9.75 26.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 9.75 0 0 1 26.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="8.25 2.75 -5.5" />
                            <Vertex pos="8.25 2.75 -6.5" />
                            <Vertex pos="8.25 1.75 -5.5" />
                            <Vertex pos="8.25 1.75 -6.5" />
                            <Vertex pos="0.25 2.75 -5.5" />
                            <Vertex pos="0.25 2.75 -6.5" />
                            <Vertex pos="0.25 1.75 -5.5" />
                            <Vertex pos="0.25 1.75 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -8.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 0.25" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -2.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 1.75" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-1.25 8.75 14.5" rot="1 0 0 0" scale="" transform="1 0 0 -1.25 0 1 0 8.75 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="5.75 2.25 -5.5" />
                            <Vertex pos="5.75 2.25 -6.5" />
                            <Vertex pos="1.25 -6.25 -5.5" />
                            <Vertex pos="1.25 -6.25 -6.5" />
                            <Vertex pos="5.75 3.75 -5.5" />
                            <Vertex pos="5.75 3.75 -6.5" />
                            <Vertex pos="0.25 -6.25 -5.5" />
                            <Vertex pos="0.25 -6.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="0.883788 -0.467888 0 -4.02903" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-0.876216 0.481919 0 3.23105" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="1 0 0 -5.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -6.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-1.25 8.75 12.5" rot="1 0 0 0" scale="" transform="1 0 0 -1.25 0 1 0 8.75 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="5.75 2.25 -5.5" />
                            <Vertex pos="5.75 2.25 -6.5" />
                            <Vertex pos="1.25 -6.25 -5.5" />
                            <Vertex pos="1.25 -6.25 -6.5" />
                            <Vertex pos="5.75 3.75 -5.5" />
                            <Vertex pos="5.75 3.75 -6.5" />
                            <Vertex pos="0.25 -6.25 -5.5" />
                            <Vertex pos="0.25 -6.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="0.883788 -0.467888 0 -4.02903" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-0.876216 0.481919 0 3.23105" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="1 0 0 -5.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -6.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-1.25 8.75 10.5" rot="1 0 0 0" scale="" transform="1 0 0 -1.25 0 1 0 8.75 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="5.75 2.25 -5.5" />
                            <Vertex pos="5.75 2.25 -6.5" />
                            <Vertex pos="1.25 -6.25 -5.5" />
                            <Vertex pos="1.25 -6.25 -6.5" />
                            <Vertex pos="5.75 3.75 -5.5" />
                            <Vertex pos="5.75 3.75 -6.5" />
                            <Vertex pos="0.25 -6.25 -5.5" />
                            <Vertex pos="0.25 -6.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="0.883788 -0.467888 0 -4.02903" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-0.876216 0.481919 0 3.23105" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="1 0 0 -5.75" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 -6.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-3.75 0.75 20.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.75 0 1 0 0.75 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="8.25 2.75 -5.5" />
                            <Vertex pos="8.25 2.75 -6.5" />
                            <Vertex pos="8.25 1.75 -5.5" />
                            <Vertex pos="8.25 1.75 -6.5" />
                            <Vertex pos="-18.75 3.25 -5.5" />
                            <Vertex pos="-18.75 3.25 -6.5" />
                            <Vertex pos="-18.75 2.25 -5.5" />
                            <Vertex pos="-18.75 2.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -8.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -18.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0.0185153 0.999829 -0 -2.90228" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="-0.0185153 -0.999829 -0 1.90245" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="-3.75 0.75 19.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.75 0 1 0 0.75 0 0 1 19.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-17.75 3.25 -5.5" />
                            <Vertex pos="-17.75 3.25 -15" />
                            <Vertex pos="-17.75 2.25 -5.5" />
                            <Vertex pos="-17.75 2.25 -15" />
                            <Vertex pos="-18.75 3.25 -5.5" />
                            <Vertex pos="-18.75 3.25 -15" />
                            <Vertex pos="-18.75 2.25 -5.5" />
                            <Vertex pos="-18.75 2.25 -15" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 17.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -18.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -3.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 2.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -15" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="-3.75 0.75 10" rot="1 0 0 0" scale="" transform="1 0 0 -3.75 0 1 0 0.75 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-15.75 3.25 -5.5" />
                            <Vertex pos="-15.75 3.25 -6.5" />
                            <Vertex pos="-15.75 2.25 -5.5" />
                            <Vertex pos="-15.75 2.25 -6.5" />
                            <Vertex pos="-18.75 3.25 -5.5" />
                            <Vertex pos="-18.75 3.25 -6.5" />
                            <Vertex pos="-18.75 2.25 -5.5" />
                            <Vertex pos="-18.75 2.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 15.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -18.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -3.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 2.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="5.25 0.75 19.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 0.75 0 0 1 19.5 0 0 0 1" group="-1" locked="0" nextFaceID="1058" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-17.75 3.25 -5.5" />
                            <Vertex pos="-17.75 3.25 -15" />
                            <Vertex pos="-17.75 2.25 -5.5" />
                            <Vertex pos="-17.75 2.25 -15" />
                            <Vertex pos="-18.75 3.25 -5.5" />
                            <Vertex pos="-18.75 3.25 -15" />
                            <Vertex pos="-18.75 2.25 -5.5" />
                            <Vertex pos="-18.75 2.25 -15" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 17.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -18.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -3.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -15" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1056" plane="0 -1 0 2.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="3.25 0.75 10" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 0.75 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-15.75 3.25 -5.5" />
                            <Vertex pos="-15.75 3.25 -6.5" />
                            <Vertex pos="-15.75 2.25 -5.5" />
                            <Vertex pos="-15.75 2.25 -6.5" />
                            <Vertex pos="-18.75 3.25 -5.5" />
                            <Vertex pos="-18.75 3.25 -6.5" />
                            <Vertex pos="-18.75 2.25 -5.5" />
                            <Vertex pos="-18.75 2.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 15.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -18.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -3.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 2.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="-3.75 9.75 20.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.75 0 1 0 9.75 0 0 1 20.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="8.25 2.75 -5.5" />
                            <Vertex pos="8.25 2.75 -6.5" />
                            <Vertex pos="8.25 1.75 -5.5" />
                            <Vertex pos="8.25 1.75 -6.5" />
                            <Vertex pos="-18.75 3.25 -5.5" />
                            <Vertex pos="-18.75 3.25 -6.5" />
                            <Vertex pos="-18.75 2.25 -5.5" />
                            <Vertex pos="-18.75 2.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 -8.25" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -18.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0.0185153 0.999829 -0 -2.90228" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="-0.0185153 -0.999829 -0 1.90245" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="-3.75 9.75 19.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.75 0 1 0 9.75 0 0 1 19.5 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-17.75 3.25 -5.5" />
                            <Vertex pos="-17.75 3.25 -15" />
                            <Vertex pos="-17.75 2.25 -5.5" />
                            <Vertex pos="-17.75 2.25 -15" />
                            <Vertex pos="-18.75 3.25 -5.5" />
                            <Vertex pos="-18.75 3.25 -15" />
                            <Vertex pos="-18.75 2.25 -5.5" />
                            <Vertex pos="-18.75 2.25 -15" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 17.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -18.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -3.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 2.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -15" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-3.75 9.75 10" rot="1 0 0 0" scale="" transform="1 0 0 -3.75 0 1 0 9.75 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-15.75 3.25 -5.5" />
                            <Vertex pos="-15.75 3.25 -6.5" />
                            <Vertex pos="-15.75 2.25 -5.5" />
                            <Vertex pos="-15.75 2.25 -6.5" />
                            <Vertex pos="-18.75 3.25 -5.5" />
                            <Vertex pos="-18.75 3.25 -6.5" />
                            <Vertex pos="-18.75 2.25 -5.5" />
                            <Vertex pos="-18.75 2.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 15.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -18.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -3.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 2.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="5.25 9.75 19.5" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 9.75 0 0 1 19.5 0 0 0 1" group="-1" locked="0" nextFaceID="1058" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-17.75 3.25 -5.5" />
                            <Vertex pos="-17.75 3.25 -15" />
                            <Vertex pos="-17.75 2.25 -5.5" />
                            <Vertex pos="-17.75 2.25 -15" />
                            <Vertex pos="-18.75 3.25 -5.5" />
                            <Vertex pos="-18.75 3.25 -15" />
                            <Vertex pos="-18.75 2.25 -5.5" />
                            <Vertex pos="-18.75 2.25 -15" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 17.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -18.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -3.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -15" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="1056" plane="0 -1 0 2.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="3.25 9.75 10" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 9.75 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="1051" nextVertexID="1401">
                        <Vertices>
                            <Vertex pos="-15.75 3.25 -5.5" />
                            <Vertex pos="-15.75 3.25 -6.5" />
                            <Vertex pos="-15.75 2.25 -5.5" />
                            <Vertex pos="-15.75 2.25 -6.5" />
                            <Vertex pos="-18.75 3.25 -5.5" />
                            <Vertex pos="-18.75 3.25 -6.5" />
                            <Vertex pos="-18.75 2.25 -5.5" />
                            <Vertex pos="-18.75 2.25 -6.5" />
                        </Vertices>
                        <Face id="1044" plane="1 -0 0 15.75" album="mbs" material="mbs_wall2" texgens="0 1 0 304 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1045" plane="-1 0 0 -18.75" album="mbs" material="mbs_wall2" texgens="0 -1 0 48 0 0 -1 -48 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1046" plane="0 1 -0 -3.25" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1047" plane="0 -1 0 2.25" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 0 -1 -128 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1048" plane="-0 0 1 5.5" album="mbs" material="mbs_wall2" texgens="1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1049" plane="0 0 -1 -6.5" album="mbs" material="mbs_wall2" texgens="-1 0 0 560 0 -1 0 -304 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
