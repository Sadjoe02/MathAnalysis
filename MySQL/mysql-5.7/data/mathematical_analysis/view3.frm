TYPE=VIEW
query=select `mathematical_analysis`.`voprosi`.`vopros` AS `vopros`,`mathematical_analysis`.`otveti`.`otvet` AS `otvet` from (`mathematical_analysis`.`otveti` join `mathematical_analysis`.`voprosi` on((`mathematical_analysis`.`otveti`.`id_vopr` = `mathematical_analysis`.`voprosi`.`id_vopr`)))
md5=d70f948972be05217ec9d3b6eba6a497
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:45
create-version=1
source=SELECT
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`voprosi`.`vopros` AS `vopros`,`mathematical_analysis`.`otveti`.`otvet` AS `otvet` from (`mathematical_analysis`.`otveti` join `mathematical_analysis`.`voprosi` on((`mathematical_analysis`.`otveti`.`id_vopr` = `mathematical_analysis`.`voprosi`.`id_vopr`)))