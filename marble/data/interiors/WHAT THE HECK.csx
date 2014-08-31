<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2014/08/17 16:00:01">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="2">
        <SceneShape id="0" type="0" file="../../../../../../Torque 1.0/torque/Constructor/staticshapes/testcube.dts" pos="0 0 0" rot="1 0 0 0" scale="1 1 1" transform="1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="1" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="2">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="light_point" gametype="Constructor" isPointEntity="1" origin="-100 -58 13.5" direction="0 -0 -0">
                        <Properties color="255 255 255" intensity="100.0" falloff_inner="1.0" falloff_outer="10.0" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="18">
                    <Brush id="0" owner="0" type="0" pos="-4 -12 1.25" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -12 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="4081" nextVertexID="5425">
                        <Vertices>
                            <Vertex pos="3 12 0.25" />
                            <Vertex pos="3 12 -0.25" />
                            <Vertex pos="3 -12 0.25" />
                            <Vertex pos="3 -12 -0.25" />
                            <Vertex pos="-3 12 0.25" />
                            <Vertex pos="-3 12 -0.25" />
                            <Vertex pos="-3 -12 0.25" />
                            <Vertex pos="-3 -12 -0.25" />
                        </Vertices>
                        <Face id="4074" plane="1 -0 0 -3" album="mbs" material="grid_X_2" texgens="0 1 0 768 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="4075" plane="-1 0 0 -3" album="mbs" material="grid_X_2" texgens="0 -1 0 768 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="4076" plane="0 1 -0 -12" album="mbs" material="grid_X_2" texgens="-1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="4077" plane="0 -1 0 -12" album="mbs" material="grid_X_2" texgens="1 0 0 192 0 0 -1 -16 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4078" plane="-0 0 1 -0.25" album="mbs" material="grid_X_2" texgens="1 0 0 192 0 -1 0 -768 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4079" plane="0 0 -1 -0.25" album="mbs" material="grid_X_2" texgens="-1 0 0 192 0 -1 0 -768 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="53.2691 -21.25 -24.25" rot="1 0 0 0" scale="" transform="1 0 0 53.2691 0 1 0 -21.25 0 0 1 -24.25 0 0 0 1" group="-1" locked="0" nextFaceID="5613" nextVertexID="9901">
                        <Vertices>
                            <Vertex pos="1.57959 2.74546 -1.75" />
                            <Vertex pos="1.57959 2.74546 1.75" />
                            <Vertex pos="1.73088 -9.53674e-006 -1.75" />
                            <Vertex pos="1.73088 -9.53674e-006 1.75" />
                            <Vertex pos="1.15186 5.01622 -1.75" />
                            <Vertex pos="1.15186 5.01622 1.75" />
                            <Vertex pos="0.521656 6.41964 -1.75" />
                            <Vertex pos="0.521656 6.41964 1.75" />
                            <Vertex pos="-0.202053 6.71302 -1.75" />
                            <Vertex pos="-0.202053 6.71302 1.75" />
                            <Vertex pos="-0.894131 5.84566 -1.75" />
                            <Vertex pos="-0.894131 5.84566 1.75" />
                            <Vertex pos="-1.4349 3.96757 -1.75" />
                            <Vertex pos="-1.4349 3.96757 1.75" />
                            <Vertex pos="-1.73088 1.40341 -1.75" />
                            <Vertex pos="-1.73088 1.40341 1.75" />
                            <Vertex pos="-1.73088 -1.4033 -1.75" />
                            <Vertex pos="-1.73088 -1.4033 1.75" />
                            <Vertex pos="-1.43489 -3.96758 -1.75" />
                            <Vertex pos="-1.43489 -3.96758 1.75" />
                            <Vertex pos="-0.894123 -5.84567 -1.75" />
                            <Vertex pos="-0.894123 -5.84567 1.75" />
                            <Vertex pos="-0.202045 -6.71302 -1.75" />
                            <Vertex pos="-0.202045 -6.71302 1.75" />
                            <Vertex pos="0.52166 -6.41963 -1.75" />
                            <Vertex pos="0.52166 -6.41963 1.75" />
                            <Vertex pos="1.15186 -5.01621 -1.75" />
                            <Vertex pos="1.15186 -5.01621 1.75" />
                            <Vertex pos="1.5796 -2.74541 -1.75" />
                            <Vertex pos="1.5796 -2.74541 1.75" />
                        </Vertices>
                        <Face id="5595" plane="0.998485 0.055025 0 -1.72826" album="mbs" material="grid_X_2" texgens="-0.0550254 0.998485 0 3.04775 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="5596" plane="0.982719 0.185105 -0 -2.06049" album="mbs" material="grid_X_2" texgens="-0.185105 0.982719 0 11.0081 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="5597" plane="0.912245 0.409645 -0 -3.10565" album="mbs" material="grid_X_2" texgens="-0.409646 0.912245 0 30.597 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="5598" plane="0.375689 0.926746 -0 -6.14536" album="mbs" material="grid_X_2" texgens="-0.926746 0.375689 0 149.453 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="5599" plane="-0.781664 0.623699 0 -4.34485" album="mbs" material="grid_X_2" texgens="-0.623698 -0.781665 0 400.031 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5600" plane="-0.960958 0.276695 0 -2.47669" album="mbs" material="grid_X_2" texgens="-0.276696 -0.960958 0 443.498 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="5601" plane="-0.993404 0.114669 0 -1.8804" album="mbs" material="grid_X_2" texgens="-0.114669 -0.993404 0 455.058 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="5602" plane="-1 0 0 -1.73088" album="mbs" material="grid_X_2" texgens="0 -1 0 461.703 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="5603" plane="-0.993404 -0.114668 0 -1.88038" album="mbs" material="grid_X_2" texgens="0.114669 -0.993404 0 468.354 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="5604" plane="-0.960958 -0.276693 0 -2.47667" album="mbs" material="grid_X_2" texgens="0.276693 -0.960958 0 479.91 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="5605" plane="-0.78166 -0.623704 0 -4.34487" album="mbs" material="grid_X_2" texgens="0.623704 -0.781661 0 523.38 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="5606" plane="0.375699 -0.926742 0 -6.14533" album="mbs" material="grid_X_2" texgens="0.926741 0.3757 0 773.959 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="5607" plane="0.912246 -0.409643 0 -3.10564" album="mbs" material="grid_X_2" texgens="0.409642 0.912246 0 892.813 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="5608" plane="0.982718 -0.185108 0 -2.0605" album="mbs" material="grid_X_2" texgens="0.185108 0.982718 0 912.4 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="5609" plane="0.998485 -0.0550221 0 -1.72826" album="mbs" material="grid_X_2" texgens="0.0550222 0.998485 0 920.361 0 0 -1 -56 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 3 2 28" />
                        </Face>
                        <Face id="5610" plane="-0 0 -1 -1.75" album="mbs" material="grid_X_2" texgens="-1 0 0 -0.111938 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 28 2 0 4 6 8 10 12 14 16 18 20 22 24 26" />
                        </Face>
                        <Face id="5611" plane="-1.04269e-005 1.96404e-006 1 -1.74998" album="mbs" material="grid_X_2" texgens="1 0 0 1.11194 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="9.33467 -79.25 -21.75" rot="1 0 0 0" scale="" transform="1 0 0 9.33467 0 1 0 -79.25 0 0 1 -21.75 0 0 0 1" group="-1" locked="0" nextFaceID="2540" nextVertexID="4471">
                        <Vertices>
                            <Vertex pos="6.99534 0.305046 -0.75" />
                            <Vertex pos="6.99534 0.305046 0.75" />
                            <Vertex pos="7.66533 7.62939e-006 -0.75" />
                            <Vertex pos="7.66533 7.62939e-006 0.75" />
                            <Vertex pos="5.10091 0.557381 -0.75" />
                            <Vertex pos="5.10091 0.557381 0.749998" />
                            <Vertex pos="2.3104 0.713287 -0.75" />
                            <Vertex pos="2.3104 0.713287 0.75" />
                            <Vertex pos="-0.894996 0.745895 -0.75" />
                            <Vertex pos="-0.894996 0.745895 0.75" />
                            <Vertex pos="-3.9594 0.649536 -0.75" />
                            <Vertex pos="-3.9594 0.649536 0.75" />
                            <Vertex pos="-6.35453 0.440834 -0.749998" />
                            <Vertex pos="-6.35453 0.440834 0.75" />
                            <Vertex pos="-7.66531 0.15593 -0.75" />
                            <Vertex pos="-7.66531 0.15593 0.75" />
                            <Vertex pos="-7.66533 -0.155937 -0.75" />
                            <Vertex pos="-7.66533 -0.155937 0.75" />
                            <Vertex pos="-6.35464 -0.440826 -0.749998" />
                            <Vertex pos="-6.35464 -0.440826 0.75" />
                            <Vertex pos="-3.95937 -0.649536 -0.749998" />
                            <Vertex pos="-3.95937 -0.649536 0.75" />
                            <Vertex pos="-0.894973 -0.745895 -0.75" />
                            <Vertex pos="-0.894973 -0.745895 0.75" />
                            <Vertex pos="2.31054 -0.713287 -0.750002" />
                            <Vertex pos="2.31054 -0.713287 0.75" />
                            <Vertex pos="5.10108 -0.557373 -0.750002" />
                            <Vertex pos="5.10108 -0.557373 0.75" />
                            <Vertex pos="6.99525 -0.305069 -0.75" />
                            <Vertex pos="6.99525 -0.305069 0.750002" />
                        </Vertices>
                        <Face id="2522" plane="0.414366 0.91011 0 -3.17625" album="mbs" material="grid_X_2" texgens="-0.910112 0.414363 0 223.242 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="2523" plane="0.132032 0.991246 -0 -1.22598" album="mbs" material="grid_X_2" texgens="-0.991245 0.132032 0 244.159 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2524" plane="0.0557834 0.998443 -0 -0.841059" album="mbs" material="grid_X_2" texgens="-0.998443 0.0557852 0 246.694 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="2525" plane="0.0101723 0.999948 -0 -0.736753" album="mbs" material="grid_X_2" texgens="-0.999948 0.0101705 0 247.847 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="2526" plane="-0.0314291 0.999506 0 -0.773656" album="mbs" material="grid_X_2" texgens="-0.999506 -0.0314288 0 248.852 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="2527" plane="-0.0868071 0.996225 0 -0.990788" album="mbs" material="grid_X_2" texgens="-0.996225 -0.086807 0 250.42 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="2528" plane="-0.212395 0.977184 0 -1.78045" album="mbs" material="grid_X_2" texgens="-0.977184 -0.212396 0 256.064 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="2529" plane="-1 3.36375e-005 0 -7.66532" album="mbs" material="grid_X_2" texgens="0 -1 0 499.68 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="2530" plane="-0.212399 -0.977183 0 -1.78049" album="mbs" material="grid_X_2" texgens="0.977183 -0.2124 0 743.309 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="2531" plane="-0.0868053 -0.996225 0 -0.990779" album="mbs" material="grid_X_2" texgens="0.996225 -0.0868073 0 748.954 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="2532" plane="-0.0314292 -0.999506 0 -0.773655" album="mbs" material="grid_X_2" texgens="0.999506 -0.0314281 0 750.522 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="2533" plane="0.010172 -0.999948 0 -0.736753" album="mbs" material="grid_X_2" texgens="0.999948 0.0101708 0 751.527 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="2534" plane="0.0557855 -0.998443 0 -0.841071" album="mbs" material="grid_X_2" texgens="0.998443 0.0557859 0 752.677 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="2535" plane="0.132034 -0.991245 0 -1.22601" album="mbs" material="grid_X_2" texgens="0.991245 0.132033 0 755.214 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="2536" plane="0.414363 -0.910112 0 -3.17622" album="mbs" material="grid_X_2" texgens="0.91011 0.414366 0 776.131 0 0 -1 -24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 3 2 28" />
                        </Face>
                        <Face id="2537" plane="-0 0 -1 -0.75" album="mbs" material="grid_X_2" texgens="-1 0 0 -2.20959 0 -1 0 0.500244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 28 2 0 4 6 8 10 12 14 16 18 20 22 24 26" />
                        </Face>
                        <Face id="2538" plane="7.27569e-007 -1.3022e-005 1 -0.750011" album="mbs" material="grid_X_2" texgens="1 0 0 3.20959 0 -1 0 0.500244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-38.6015 -66 0.15625" rot="1 0 0 0" scale="" transform="1 0 0 -38.6015 0 1 0 -66 0 0 1 0.15625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.398453 -1.5 0.65625" />
                            <Vertex pos="-0.398453 -1.5 -0.65625" />
                            <Vertex pos="-0.398453 1.5 0.65625" />
                            <Vertex pos="-0.398453 1.5 -0.65625" />
                            <Vertex pos="0.398453 -1.5 0.65625" />
                            <Vertex pos="0.351551 -1.5 -0.65625" />
                            <Vertex pos="0.398453 1.5 0.65625" />
                            <Vertex pos="0.351551 1.5 -0.65625" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.398453" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0 0 -1 -21 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 12.7505 0 0 -1 -21 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 35.2495 0 0 -1 -21 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.65625" album="mbs" material="grid_X_2" texgens="1 0 0 12.7505 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.999362 0 -0.0357118 -0.374763" album="mbs" material="grid_X_2" texgens="0 1 0 48 -0.0357106 0 -0.999362 -20.5849 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.65625" album="mbs" material="grid_X_2" texgens="-1 0 0 35.2495 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-36.3984 -66 0.15625" rot="1 0 0 0" scale="" transform="1 0 0 -36.3984 0 1 0 -66 0 0 1 0.15625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.398449 -1.5 0.65625" />
                            <Vertex pos="0.398449 -1.5 -0.65625" />
                            <Vertex pos="0.398449 1.5 0.65625" />
                            <Vertex pos="0.398449 1.5 -0.65625" />
                            <Vertex pos="-0.398449 -1.5 0.65625" />
                            <Vertex pos="-0.351547 -1.5 -0.65625" />
                            <Vertex pos="-0.398449 1.5 0.65625" />
                            <Vertex pos="-0.351547 1.5 -0.65625" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.398449" album="mbs" material="grid_X_2" texgens="0 1 0 48 0 0 -1 -21 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 83.2496 0 0 -1 -21 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 -35.2496 0 0 -1 -21 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="0 0 1 -0.65625" album="mbs" material="grid_X_2" texgens="1 0 0 83.2496 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="-0.999362 -0 -0.0357118 -0.374759" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0.0357106 0 -0.999362 -20.5849 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.65625" album="mbs" material="grid_X_2" texgens="-1 0 0 -35.2496 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-38.1328 -66 2.40629" rot="1 0 0 0" scale="" transform="1 0 0 -38.1328 0 1 0 -66 0 0 1 2.40629 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0703011 -1.5 1.59371" />
                            <Vertex pos="0.0702972 -1.5 1.59371" />
                            <Vertex pos="-0.0703011 -1.5 -1.59371" />
                            <Vertex pos="0.0702972 -1.5 -0.656231" />
                            <Vertex pos="-0.0703011 1.5 1.59371" />
                            <Vertex pos="0.0702972 1.5 1.59371" />
                            <Vertex pos="-0.0703011 1.5 -1.59371" />
                            <Vertex pos="0.0702972 1.5 -0.656231" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 27.7505 0 0 -1 -93.0013 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 20.2495 0 0 -1 -93.0013 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -1.59371" album="mbs" material="grid_X_2" texgens="1 0 0 27.7505 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-1 -0 -0 -0.0703011" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0 0 -1 -93.0013 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="1 0 0 -0.0702972" album="mbs" material="grid_X_2" texgens="0 1 0 48 0 0 -1 -93.0013 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.98894 0 -0.148316 -0.166849" album="mbs" material="grid_X_2" texgens="0 1 0 48 -0.148315 0 -0.98894 -92.7978 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-36.8672 -66 2.40625" rot="1 0 0 0" scale="" transform="1 0 0 -36.8672 0 1 0 -66 0 0 1 2.40625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0703011 -1.5 1.59375" />
                            <Vertex pos="-0.0702972 -1.5 1.59375" />
                            <Vertex pos="0.0703011 -1.5 -1.59375" />
                            <Vertex pos="-0.0702972 -1.5 -0.65627" />
                            <Vertex pos="0.0703011 1.5 1.59375" />
                            <Vertex pos="-0.0702972 1.5 1.59375" />
                            <Vertex pos="0.0703011 1.5 -1.59375" />
                            <Vertex pos="-0.0702972 1.5 -0.65627" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 68.2495 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 -20.2495 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="2" plane="0 0 1 -1.59375" album="mbs" material="grid_X_2" texgens="1 0 0 68.2495 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="3" plane="1 0 0 -0.070301" album="mbs" material="grid_X_2" texgens="0 1 0 48 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -0.0702972" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="-0.98894 0 -0.148316 -0.166855" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0.148315 0 -0.98894 -92.7966 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-37.9453 -66 2.87501" rot="1 0 0 0" scale="" transform="1 0 0 -37.9453 0 1 0 -66 0 0 1 2.87501 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.117203 -1.5 1.12499" />
                            <Vertex pos="0.117199 -1.5 1.12499" />
                            <Vertex pos="-0.117203 -1.5 -1.12499" />
                            <Vertex pos="0.117199 -1.5 -0.562482" />
                            <Vertex pos="-0.117203 1.5 1.12499" />
                            <Vertex pos="0.117199 1.5 1.12499" />
                            <Vertex pos="-0.117203 1.5 -1.12499" />
                            <Vertex pos="0.117199 1.5 -0.562482" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 33.7505 0 0 -1 -108 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 14.2495 0 0 -1 -108 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -1.12499" album="mbs" material="grid_X_2" texgens="1 0 0 33.7505 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-1 -0 -0 -0.117203" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0 0 -1 -108 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="1 0 0 -0.117199" album="mbs" material="grid_X_2" texgens="0 1 0 48 0 0 -1 -108 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.923064 0 -0.384647 -0.324539" album="mbs" material="grid_X_2" texgens="0 1 0 48 -0.38465 0 -0.923062 -107.035 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-37.0547 -66 2.875" rot="1 0 0 0" scale="" transform="1 0 0 -37.0547 0 1 0 -66 0 0 1 2.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.117203 -1.5 1.125" />
                            <Vertex pos="-0.117199 -1.5 1.125" />
                            <Vertex pos="0.117203 -1.5 -1.125" />
                            <Vertex pos="-0.117199 -1.5 -0.562497" />
                            <Vertex pos="0.117203 1.5 1.125" />
                            <Vertex pos="-0.117199 1.5 1.125" />
                            <Vertex pos="0.117203 1.5 -1.125" />
                            <Vertex pos="-0.117199 1.5 -0.562497" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 62.2495 0 0 -1 -108 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 -14.2495 0 0 -1 -108 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="2" plane="0 0 1 -1.125" album="mbs" material="grid_X_2" texgens="1 0 0 62.2495 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="3" plane="1 0 0 -0.117203" album="mbs" material="grid_X_2" texgens="0 1 0 48 0 0 -1 -108 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -0.117199" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0 0 -1 -108 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="-0.923061 0 -0.384653 -0.324548" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0.38465 0 -0.923062 -107.035 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-37.664 -66 3.15625" rot="1 0 0 0" scale="" transform="1 0 0 -37.664 0 1 0 -66 0 0 1 3.15625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.164051 -1.5 0.843748" />
                            <Vertex pos="0.164047 -1.5 0.843748" />
                            <Vertex pos="-0.164051 -1.5 -0.843748" />
                            <Vertex pos="0.164047 -1.5 -0.656248" />
                            <Vertex pos="-0.164051 1.5 0.843748" />
                            <Vertex pos="0.164047 1.5 0.843748" />
                            <Vertex pos="-0.164051 1.5 -0.843748" />
                            <Vertex pos="0.164047 1.5 -0.656248" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 42.7505 0 0 -1 -117 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 5.24951 0 0 -1 -117 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -0.843748" album="mbs" material="grid_X_2" texgens="1 0 0 42.7505 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-1 -0 -0 -0.164051" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0 0 -1 -117 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="1 0 0 -0.164047" album="mbs" material="grid_X_2" texgens="0 1 0 48 0 0 -1 -117 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0.496169 0 -0.868226 -0.651167" album="mbs" material="grid_X_2" texgens="0 1 0 48 -0.868227 0 -0.496167 -109.817 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-37.336 -66 3.15625" rot="1 0 0 0" scale="" transform="1 0 0 -37.336 0 1 0 -66 0 0 1 3.15625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.164051 -1.5 0.84375" />
                            <Vertex pos="-0.164047 -1.5 0.84375" />
                            <Vertex pos="0.164051 -1.5 -0.84375" />
                            <Vertex pos="-0.164047 -1.5 -0.65625" />
                            <Vertex pos="0.164051 1.5 0.84375" />
                            <Vertex pos="-0.164047 1.5 0.84375" />
                            <Vertex pos="0.164051 1.5 -0.84375" />
                            <Vertex pos="-0.164047 1.5 -0.65625" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 53.2495 0 0 -1 -117 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 -5.24951 0 0 -1 -117 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="2" plane="0 0 1 -0.84375" album="mbs" material="grid_X_2" texgens="1 0 0 53.2495 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="3" plane="1 0 0 -0.164051" album="mbs" material="grid_X_2" texgens="0 1 0 48 0 0 -1 -117 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -0.164047" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0 0 -1 -117 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="-0.496168 0 -0.868226 -0.651169" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0.868227 0 -0.496167 -109.817 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-38.6015 -66 2.40625" rot="1 0 0 0" scale="" transform="1 0 0 -38.6015 0 1 0 -66 0 0 1 2.40625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.398453 -1.5 1.59375" />
                            <Vertex pos="-0.398453 -1.5 -1.59375" />
                            <Vertex pos="-0.398453 1.5 1.59375" />
                            <Vertex pos="-0.398453 1.5 -1.59375" />
                            <Vertex pos="0.398449 -1.5 1.59375" />
                            <Vertex pos="0.398449 -1.5 -1.59375" />
                            <Vertex pos="0.398449 1.5 1.59375" />
                            <Vertex pos="0.398449 1.5 -1.59375" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.398453" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 12.7505 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 35.2495 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="1 0 0 -0.398449" album="mbs" material="grid_X_2" texgens="0 1 0 48 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="4" plane="0 -0 1 -1.59375" album="mbs" material="grid_X_2" texgens="1 0 0 12.7505 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.59375" album="mbs" material="grid_X_2" texgens="-1 0 0 35.2495 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-36.3985 -66 2.40625" rot="1 0 0 0" scale="" transform="1 0 0 -36.3985 0 1 0 -66 0 0 1 2.40625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.398453 -1.5 1.59375" />
                            <Vertex pos="0.398453 -1.5 -1.59375" />
                            <Vertex pos="0.398453 1.5 1.59375" />
                            <Vertex pos="0.398453 1.5 -1.59375" />
                            <Vertex pos="-0.398449 -1.5 1.59375" />
                            <Vertex pos="-0.398449 -1.5 -1.59375" />
                            <Vertex pos="-0.398449 1.5 1.59375" />
                            <Vertex pos="-0.398449 1.5 -1.59375" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.398453" album="mbs" material="grid_X_2" texgens="0 1 0 48 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 83.2495 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 -35.2495 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="-1 -0 -0 -0.398449" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0 0 -1 -93 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="4" plane="0 0 1 -1.59375" album="mbs" material="grid_X_2" texgens="1 0 0 83.2495 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.59375" album="mbs" material="grid_X_2" texgens="-1 0 0 -35.2495 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-38.625 -66 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -38.625 0 1 0 -66 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.375 -1.5 0.75" />
                            <Vertex pos="-0.375 -1.5 -0.75" />
                            <Vertex pos="-0.375 1.5 0.75" />
                            <Vertex pos="-0.375 1.5 -0.75" />
                            <Vertex pos="0.375 -1.5 0.75" />
                            <Vertex pos="0.375 -1.5 -0.75" />
                            <Vertex pos="0.375 1.5 0.75" />
                            <Vertex pos="0.375 1.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -0.375" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0 0 -1 24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 12 0 0 -1 24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 36 0 0 -1 24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="1 0 0 -0.375" album="mbs" material="grid_X_2" texgens="0 1 0 48 0 0 -1 24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="4" plane="0 -0 1 -0.75" album="mbs" material="grid_X_2" texgens="1 0 0 12 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.75" album="mbs" material="grid_X_2" texgens="-1 0 0 36 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-36.375 -66 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -36.375 0 1 0 -66 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.375 -1.5 0.75" />
                            <Vertex pos="0.375 -1.5 -0.75" />
                            <Vertex pos="0.375 1.5 0.75" />
                            <Vertex pos="0.375 1.5 -0.75" />
                            <Vertex pos="-0.375 -1.5 0.75" />
                            <Vertex pos="-0.375 -1.5 -0.75" />
                            <Vertex pos="-0.375 1.5 0.75" />
                            <Vertex pos="-0.375 1.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.375" album="mbs" material="grid_X_2" texgens="0 1 0 48 0 0 -1 24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1.5" album="mbs" material="grid_X_2" texgens="1 0 0 84 0 0 -1 24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="mbs" material="grid_X_2" texgens="-1 0 0 -36 0 0 -1 24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="-1 -0 -0 -0.375" album="mbs" material="grid_X_2" texgens="0 -1 0 48 0 0 -1 24 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.75" album="mbs" material="grid_X_2" texgens="1 0 0 84 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.75" album="mbs" material="grid_X_2" texgens="-1 0 0 -36 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-96 -43.25 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -96 0 1 0 -43.25 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="487" nextVertexID="649">
                        <Vertices>
                            <Vertex pos="4 5.25 4" />
                            <Vertex pos="4 5.25 -4" />
                            <Vertex pos="4 -5.25 4" />
                            <Vertex pos="4 -5.25 -4" />
                            <Vertex pos="-4 5.25 4" />
                            <Vertex pos="-4 5.25 -4" />
                            <Vertex pos="-4 -5.25 4" />
                            <Vertex pos="-4 -5.25 -4" />
                        </Vertices>
                        <Face id="480" plane="1 -0 0 -4" album="mbs" material="grid_X_2" texgens="0 1 0 336 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="481" plane="-1 0 0 -4" album="mbs" material="grid_X_2" texgens="0 -1 0 336 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="482" plane="0 1 -0 -5.25" album="mbs" material="grid_X_2" texgens="-1 0 0 256 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="483" plane="0 -1 0 -5.25" album="mbs" material="grid_X_2" texgens="1 0 0 256 0 0 -1 -256 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="484" plane="-0 0 1 -4" album="mbs" material="grid_X_2" texgens="1 0 0 256 0 -1 0 -336 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="485" plane="0 0 -1 -4" album="mbs" material="grid_X_2" texgens="-1 0 0 256 0 -1 0 -336 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-105.5 -25 0" rot="1 0 0 0" scale="" transform="1 0 0 -105.5 0 1 0 -25 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="931" nextVertexID="1241">
                        <Vertices>
                            <Vertex pos="5 5 7.5" />
                            <Vertex pos="5 5 -7.5" />
                            <Vertex pos="5 -5 7.5" />
                            <Vertex pos="5 -5 -7.5" />
                            <Vertex pos="-5 5 7.5" />
                            <Vertex pos="-5 5 -7.5" />
                            <Vertex pos="-5 -5 7.5" />
                            <Vertex pos="-5 -5 -7.5" />
                        </Vertices>
                        <Face id="924" plane="1 -0 0 -5" album="mbs" material="grid_X_2" texgens="0 1 0 320 0 0 -1 -480 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="925" plane="-1 0 0 -5" album="mbs" material="grid_X_2" texgens="0 -1 0 320 0 0 -1 -480 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="926" plane="0 1 -0 -5" album="mbs" material="grid_X_2" texgens="-1 0 0 320 0 0 -1 -480 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="927" plane="0 -1 0 -5" album="mbs" material="grid_X_2" texgens="1 0 0 320 0 0 -1 -480 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="928" plane="-0 0 1 -7.5" album="mbs" material="grid_X_2" texgens="1 0 0 320 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="929" plane="0 0 -1 -7.5" album="mbs" material="grid_X_2" texgens="-1 0 0 320 0 -1 0 -320 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
