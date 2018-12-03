rm *.dll
rm *.exe

ls -l

mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -out:TrafficLightAlgorithms.dll TrafficLightAlgorithms.cs

mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:TrafficLightAlgorithms.dll -out:TrafficLight.dll TrafficLight.cs

mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:TrafficLight.dll -out:TrafficLightMain.dll TrafficLightMain.cs

mcs -r:System -r:System.Windows.Forms -r:System.Drawing -r:TrafficLight.dll -out:TrafficLightMain.exe TrafficLightMain.cs

./TrafficLightMain.exe