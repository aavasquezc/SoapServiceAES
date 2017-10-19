docker pull aavasquezc/aesmodvalarq
docker run -d -p 83:83 --name mycontainer aavasquezc/aesmodvalarq
docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" mycontainer
read -p "Press enter to continue" nothing