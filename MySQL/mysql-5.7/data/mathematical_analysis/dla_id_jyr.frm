TYPE=VIEW
query=select `mathematical_analysis`.`jyrnal_izychenia`.`id_jyr` AS `id_jyr`,`mathematical_analysis`.`jyrnal_izychenia`.`id_temi` AS `id_temi`,`mathematical_analysis`.`jyrnal_izychenia`.`id_users` AS `id_users`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi` from (`mathematical_analysis`.`jyrnal_izychenia` join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`jyrnal_izychenia`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`)))
md5=4899385245c352656ac5ee8b0862c50b
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:44
create-version=1
source=SELECT\n  `jyrnal_izychenia`.`id_jyr` AS `id_jyr`,\n  `jyrnal_izychenia`.`id_temi` AS `id_temi`,\n  `jyrnal_izychenia`.`id_users` AS `id_users`,\n  `temi`.`name_temi` AS `name_temi`\nFROM (`jyrnal_izychenia`\n  JOIN `temi`\n    ON ((`jyrnal_izychenia`.`id_temi` = `temi`.`id_temi`)))
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`jyrnal_izychenia`.`id_jyr` AS `id_jyr`,`mathematical_analysis`.`jyrnal_izychenia`.`id_temi` AS `id_temi`,`mathematical_analysis`.`jyrnal_izychenia`.`id_users` AS `id_users`,`mathematical_analysis`.`temi`.`name_temi` AS `name_temi` from (`mathematical_analysis`.`jyrnal_izychenia` join `mathematical_analysis`.`temi` on((`mathematical_analysis`.`jyrnal_izychenia`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`)))
