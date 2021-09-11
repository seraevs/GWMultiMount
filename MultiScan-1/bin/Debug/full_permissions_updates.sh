##################################################
####### Script for copy updetes multi scan #######
#################### antivirus ###################
######## The same example using bash shell #######
########## Written by Evstigneev Sergey ##########
##################################################
#Check if folder /opt/ANTIVIRUS/MULTISCAN exists
if [ -d /opt/ANTIVIRUS/MULTISCAN ]
then

	chmod 7777 -R /opt/ANTIVIRUS/MULTISCAN

fi

sleep 4


	chmod 7777 -R /mnt/hd/sda1/opt/AVUPDATES
	sleep 1


	chmod 7777 -R /mnt/hd/sda1/opt/AVUPDATES/av
	sleep 1


	chmod 7777 -R /mnt/hd/sda1/opt/AVUPDATES/lib
	sleep 1


	chmod 7777 -R /mnt/hd/sda1/opt/AVUPDATES/uvscan


echo "****************************************"
echo "******** Script Finished Work. *********"
echo "****************************************"