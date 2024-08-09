TYPE=VIEW
query=select `mathematical_analysis`.`konspect_lekcii`.`konspect` AS `konspect`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel` from ((`mathematical_analysis`.`razdel` left join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`))) left join `mathematical_analysis`.`konspect_lekcii` on((`mathematical_analysis`.`konspect_lekcii`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`)))
md5=8eab9c0dfa67d2910083cb58ebdcee07
updatable=0
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:44
create-version=1
source=SELECT\n  `konspect_lekcii`.`konspect` AS `konspect`,\n  `temi`.`name_temi` AS `name_temi`,\n  `razdel`.`name_razdel` AS `name_razdel`\nFROM ((`razdel`\n  LEFT JOIN `temi`\n    ON ((`temi`.`id_razdel` = `razdel`.`id_razdel`)))\n  LEFT JOIN `konspect_lekcii`\n    ON ((`konspect_lekcii`.`id_temi` = `temi`.`id_temi`)))
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`konspect_lekcii`.`konspect` AS `konspect`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel` from ((`mathematical_analysis`.`razdel` left join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`))) left join `mathematical_analysis`.`konspect_lekcii` on((`mathematical_analysis`.`konspect_lekcii`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`)))
