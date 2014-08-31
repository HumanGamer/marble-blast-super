<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2014/08/26 16:33:19">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="1" export_useSunlight="0" />
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
                <Brushes nextBrushID="45">
                    <Brush id="0" owner="0" type="0" pos="1 12 3.75" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 12 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 -6.25" />
                            <Vertex pos="3 6 -6.75" />
                            <Vertex pos="3 -6 0.25" />
                            <Vertex pos="3 -6 -0.25" />
                            <Vertex pos="-3 6 -6.25" />
                            <Vertex pos="-3 6 -6.75" />
                            <Vertex pos="-3 -6 0.25" />
                            <Vertex pos="-3 -6 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -6" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0.476283 0.879292 2.63788" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0 -0.476283 -0.879292 -3.07752" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="1 0 3.75" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 0 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 -6 0.25" />
                            <Vertex pos="3 -6 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 -6 0.25" />
                            <Vertex pos="-3 -6 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -6" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="1 24 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 24 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 -6 0.25" />
                            <Vertex pos="3 -6 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 -6 0.25" />
                            <Vertex pos="-3 -6 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -6" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-5 24 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 24 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 0 0.25" />
                            <Vertex pos="-3 0 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-11 26 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 26 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 2.25" />
                            <Vertex pos="3 6 1.75" />
                            <Vertex pos="3 4 0.25" />
                            <Vertex pos="3 4 -0.25" />
                            <Vertex pos="-3 6 2.25" />
                            <Vertex pos="-3 6 1.75" />
                            <Vertex pos="-3 4 0.25" />
                            <Vertex pos="-3 4 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 -0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 4" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0 -0.707107 0.707107 2.65165" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0.707107 -0.707107 -3.0052" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-15 22 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 22 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 4 2.25" />
                            <Vertex pos="3 4 1.75" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 4 2.25" />
                            <Vertex pos="-3 4 1.75" />
                        </Vertices>
                        <Face id="1788" plane="1 0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 4" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0.707107 0.707107 -4.41942" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0 -0.707107 -0.707107 4.06586" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-21 26 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 26 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 2.25" />
                            <Vertex pos="3 6 1.75" />
                            <Vertex pos="3 4 0.25" />
                            <Vertex pos="3 4 -0.25" />
                            <Vertex pos="-3 6 2.25" />
                            <Vertex pos="-3 6 1.75" />
                            <Vertex pos="-3 4 0.25" />
                            <Vertex pos="-3 4 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 -0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 4" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0 -0.707107 0.707107 2.65165" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0.707107 -0.707107 -3.0052" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-25 20 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -25 0 1 0 20 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 4 2.25" />
                            <Vertex pos="3 4 1.75" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 4 2.25" />
                            <Vertex pos="-3 4 1.75" />
                        </Vertices>
                        <Face id="1788" plane="1 0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 4" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0.707107 0.707107 -4.41942" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0 -0.707107 -0.707107 4.06586" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-29 30.5 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 30.5 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 0 0.25" />
                            <Vertex pos="-3 0 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-29 32.5 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 32.5 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 2.25" />
                            <Vertex pos="3 6 1.75" />
                            <Vertex pos="3 4 0.25" />
                            <Vertex pos="3 4 -0.25" />
                            <Vertex pos="-3 6 2.25" />
                            <Vertex pos="-3 6 1.75" />
                            <Vertex pos="-3 4 0.25" />
                            <Vertex pos="-3 4 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="PATTERN_COOL1" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 -0 0 -3" album="levelcreating" material="PATTERN_COOL1" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="PATTERN_COOL1" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 4" album="levelcreating" material="PATTERN_COOL1" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0 -0.707107 0.707107 2.65165" album="levelcreating" material="PATTERN_COOL1" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0.707107 -0.707107 -3.0052" album="levelcreating" material="PATTERN_COOL1" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-29 56.5 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 56.5 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 0 0.25" />
                            <Vertex pos="-3 0 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-9 56.5 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 56.5 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 2.25" />
                            <Vertex pos="3 6 1.75" />
                            <Vertex pos="3 4 0.25" />
                            <Vertex pos="3 4 -0.25" />
                            <Vertex pos="-3 6 2.25" />
                            <Vertex pos="-3 6 1.75" />
                            <Vertex pos="-3 4 0.25" />
                            <Vertex pos="-3 4 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 -0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 4" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0 -0.707107 0.707107 2.65165" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0.707107 -0.707107 -3.0052" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-13 52.5 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 52.5 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 4 2.25" />
                            <Vertex pos="3 4 1.75" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 4 2.25" />
                            <Vertex pos="-3 4 1.75" />
                        </Vertices>
                        <Face id="1788" plane="1 0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 4" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0.707107 0.707107 -4.41942" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0 -0.707107 -0.707107 4.06586" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-19 56.5 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 56.5 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 2.25" />
                            <Vertex pos="3 6 1.75" />
                            <Vertex pos="3 4 0.25" />
                            <Vertex pos="3 4 -0.25" />
                            <Vertex pos="-3 6 2.25" />
                            <Vertex pos="-3 6 1.75" />
                            <Vertex pos="-3 4 0.25" />
                            <Vertex pos="-3 4 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 -0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 4" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0 -0.707107 0.707107 2.65165" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0.707107 -0.707107 -3.0052" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-23 50.5 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -23 0 1 0 50.5 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 4 2.25" />
                            <Vertex pos="3 4 1.75" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 4 2.25" />
                            <Vertex pos="-3 4 1.75" />
                        </Vertices>
                        <Face id="1788" plane="1 0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 4" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0.707107 0.707107 -4.41942" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0 -0.707107 -0.707107 4.06586" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-7 53 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 53 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 2.25" />
                            <Vertex pos="3 6 1.75" />
                            <Vertex pos="3 0 2.25" />
                            <Vertex pos="3 0 1.75" />
                            <Vertex pos="1 6 0.25" />
                            <Vertex pos="1 6 -0.25" />
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="1 0 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_4" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 1" album="levelcreating" material="GRID_X_4" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0.707107 0 0.707107 0.53033" album="levelcreating" material="GRID_X_4" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0.707107 0 -0.707107 -0.883883" album="levelcreating" material="GRID_X_4" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="14 56.5 30.25" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 56.5 0 0 1 30.25 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 0 0.25" />
                            <Vertex pos="-3 0 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="14 50.5 30.25" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 50.5 0 0 1 30.25 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 0 3.75" />
                            <Vertex pos="3 0 3.25" />
                            <Vertex pos="2.5 6 0.25" />
                            <Vertex pos="2.5 6 -0.25" />
                            <Vertex pos="2.5 0 3.75" />
                            <Vertex pos="2.5 0 3.25" />
                        </Vertices>
                        <Face id="1788" plane="1 0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0.503871 0.863779 -3.23917" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0 -0.503871 -0.863779 2.80728" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="14 44.5 33.75" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 44.5 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 6 0.25" />
                            <Vertex pos="2.5 6 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="13.5 44.5 33.75" rot="1 0 0 0" scale="" transform="1 0 0 13.5 0 1 0 44.5 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="1.5 3.5 0.25" />
                            <Vertex pos="1.5 3.5 -0.25" />
                            <Vertex pos="1.5 3 0.25" />
                            <Vertex pos="1.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 1.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="12.035 44.5 34.008" rot="0 -1 0 0.0872659" scale="" transform="0.996195 0 0.0871557 12.035 0 1 0 44.5 -0.0871557 0 0.996195 34.008 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 3.5 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="11.1259 44.5 34.3714" rot="0 -1 0 0.0872659" scale="" transform="0.996195 0 0.0871557 11.1259 0 1 0 44.5 -0.0871557 0 0.996195 34.3714 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 3.5 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="10.1059 44.5 34.8614" rot="0 -1 0 0.0872659" scale="" transform="0.996195 0 0.0871557 10.1059 0 1 0 44.5 -0.0871557 0 0.996195 34.8614 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 3.5 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="9.05594 44.5 35.3514" rot="0 -1 0 0.0872659" scale="" transform="0.996195 0 0.0871557 9.05594 0 1 0 44.5 -0.0871557 0 0.996195 35.3514 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 3.5 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="9.05594 45.6915 35.2972" rot="-0.706774 -0.706774 -0.0308584 0.123393" scale="" transform="0.996195 0 0.0871557 9.05594 0.00759612 0.996195 -0.0868241 45.6915 -0.0868241 0.0871557 0.992404 35.2972 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 3.5 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="9.05594 46.9415 35.5372" rot="-0.706774 -0.706774 -0.0308584 0.123393" scale="" transform="0.996195 0 0.0871557 9.05594 0.00759612 0.996195 -0.0868241 46.9415 -0.0868241 0.0871557 0.992404 35.5372 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 3.5 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="9.05594 48.1115 35.7872" rot="-0.706774 -0.706774 -0.0308584 0.123393" scale="" transform="0.996195 0 0.0871557 9.05594 0.00759612 0.996195 -0.0868241 48.1115 -0.0868241 0.0871557 0.992404 35.7872 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 3.5 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="9.05594 49.3615 36.0272" rot="-0.706774 -0.706774 -0.0308584 0.123393" scale="" transform="0.996195 0 0.0871557 9.05594 0.00759612 0.996195 -0.0868241 49.3615 -0.0868241 0.0871557 0.992404 36.0272 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 3.5 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="14 56.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 56.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 0 0.25" />
                            <Vertex pos="-3 0 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="5 56.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 56.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 0 1.75" />
                            <Vertex pos="2 0 1.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -2" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0.83205 0 0.5547 -2.63483" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0.83205 0 -0.5547 2.35748" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="5 58.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 58.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 0 1.75" />
                            <Vertex pos="2 0 1.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="FRICTION_LOW" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2" album="levelcreating" material="FRICTION_LOW" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -2" album="levelcreating" material="FRICTION_LOW" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="FRICTION_LOW" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0.83205 0 0.5547 -2.63483" album="levelcreating" material="FRICTION_LOW" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0.83205 0 -0.5547 2.35748" album="levelcreating" material="FRICTION_LOW" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="5 60.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 60.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 0 1.75" />
                            <Vertex pos="2 0 1.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="FRICTION_NONE" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2" album="levelcreating" material="FRICTION_NONE" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -2" album="levelcreating" material="FRICTION_NONE" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="FRICTION_NONE" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0.83205 0 0.5547 -2.63483" album="levelcreating" material="FRICTION_NONE" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0.83205 0 -0.5547 2.35748" album="levelcreating" material="FRICTION_NONE" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-1.5 60.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 60.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 0 1.75" />
                            <Vertex pos="2 0 1.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -2" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0.83205 0 0.5547 -2.63483" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0.83205 0 -0.5547 2.35748" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-1.5 58.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 58.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 0 1.75" />
                            <Vertex pos="2 0 1.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="FRICTION_LOW" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2" album="levelcreating" material="FRICTION_LOW" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -2" album="levelcreating" material="FRICTION_LOW" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="FRICTION_LOW" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0.83205 0 0.5547 -2.63483" album="levelcreating" material="FRICTION_LOW" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0.83205 0 -0.5547 2.35748" album="levelcreating" material="FRICTION_LOW" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-1.5 56.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 56.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 0 1.75" />
                            <Vertex pos="2 0 1.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="FRICTION_NONE" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2" album="levelcreating" material="FRICTION_NONE" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -2" album="levelcreating" material="FRICTION_NONE" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="FRICTION_NONE" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0.83205 0 0.5547 -2.63483" album="levelcreating" material="FRICTION_NONE" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0.83205 0 -0.5547 2.35748" album="levelcreating" material="FRICTION_NONE" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-8.5 58.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 58.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 0 1.75" />
                            <Vertex pos="2 0 1.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -2" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0.83205 0 0.5547 -2.63483" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0.83205 0 -0.5547 2.35748" album="levelcreating" material="FRICTION_RAMP_YELLOW" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-8.5 60.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 60.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 0 1.75" />
                            <Vertex pos="2 0 1.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="FRICTION_LOW" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2" album="levelcreating" material="FRICTION_LOW" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -2" album="levelcreating" material="FRICTION_LOW" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="FRICTION_LOW" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0.83205 0 0.5547 -2.63483" album="levelcreating" material="FRICTION_LOW" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0.83205 0 -0.5547 2.35748" album="levelcreating" material="FRICTION_LOW" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-8.5 56.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 56.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 0 1.75" />
                            <Vertex pos="2 0 1.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="FRICTION_NONE" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2" album="levelcreating" material="FRICTION_NONE" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -2" album="levelcreating" material="FRICTION_NONE" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="FRICTION_NONE" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="0.83205 0 0.5547 -2.63483" album="levelcreating" material="FRICTION_NONE" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="-0.83205 0 -0.5547 2.35748" album="levelcreating" material="FRICTION_NONE" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-21 56.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 56.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 0 0.25" />
                            <Vertex pos="3 0 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 0 0.25" />
                            <Vertex pos="-3 0 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 -3" album="levelcreating" material="GRID_X_1" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -6" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 -0" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="GRID_X_1" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="GRID_X_1" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="9.05594 50.4415 35.5372" rot="-0.706774 -0.706774 -0.0308584 0.123393" scale="" transform="0.996195 0 0.0871557 9.05594 0.00759612 0.996195 -0.0868241 50.4415 -0.0868241 0.0871557 0.992404 35.5372 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 3.5 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="9.05594 51.6115 35.7872" rot="-0.706774 -0.706774 -0.0308584 0.123393" scale="" transform="0.996195 0 0.0871557 9.05594 0.00759612 0.996195 -0.0868241 51.6115 -0.0868241 0.0871557 0.992404 35.7872 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 3.5 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="9.05594 52.8615 36.0272" rot="-0.706774 -0.706774 -0.0308584 0.123393" scale="" transform="0.996195 0 0.0871557 9.05594 0.00759612 0.996195 -0.0868241 52.8615 -0.0868241 0.0871557 0.992404 36.0272 0 0 0 1" group="-1" locked="0" nextFaceID="1795" nextVertexID="2249">
                        <Vertices>
                            <Vertex pos="3 3.5 0.25" />
                            <Vertex pos="3 3.5 -0.25" />
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="2.5 3.5 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                        </Vertices>
                        <Face id="1788" plane="1 -0 0 -3" album="levelcreating" material="EDGE_WHITE2" texgens="0 1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1789" plane="-1 0 0 2.5" album="levelcreating" material="EDGE_WHITE2" texgens="0 -1 0 384 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1790" plane="0 1 -0 -3.5" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1791" plane="0 -1 0 3" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1792" plane="-0 0 1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1793" plane="0 0 -1 -0.25" album="levelcreating" material="EDGE_WHITE2" texgens="-1 0 0 192 0 -1 0 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="32 32">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
