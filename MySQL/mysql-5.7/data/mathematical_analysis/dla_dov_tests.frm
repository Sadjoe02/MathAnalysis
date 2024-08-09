TYPE=VIEW
query=select `mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel`,`mathematical_analysis`.`razdel`.`id_razdel` AS `id_razdel`,`mathematical_analysis`.`temi`.`id_temi` AS `id_temi` from (`mathematical_analysis`.`temi` join `mathematical_analysis`.`razdel` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`)))
md5=8f06d05cfc13823aec779935120b306e
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:44
create-version=1
source=SELECT\n  `temi`.`name_temi` AS `name_temi`,\n  `razdel`.`name_razdel` AS `name_razdel`,\n  `razdel`.`id_razdel` AS `id_razdel`,\n  `temi`.`id_temi` AS `id_temi`\nFROM (`temi`\n  JOIN `razdel`\n    ON ((`temi`.`id_razdel` = `razdel`.`id_razdel`)))
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,`mathematical_analysis`.`razdel`.`name_razdel` AS `name_razdel`,`mathematical_analysis`.`razdel`.`id_razdel` AS `id_razdel`,`mathematical_analysis`.`temi`.`id_temi` AS `id_temi` from (`mathematical_analysis`.`temi` join `mathematical_analysis`.`razdel` on((`mathematical_analysis`.`temi`.`id_razdel` = `mathematical_analysis`.`razdel`.`id_razdel`)))
