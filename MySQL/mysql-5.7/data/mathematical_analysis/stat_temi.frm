TYPE=VIEW
query=select `mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,count(`mathematical_analysis`.`jyrnal_izychenia`.`id_users`) AS `colvo_user` from (`mathematical_analysis`.`temi` left join `mathematical_analysis`.`jyrnal_izychenia` on((`mathematical_analysis`.`jyrnal_izychenia`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`))) group by `mathematical_analysis`.`temi`.`name_temi`
md5=5b19b9d8d7920a5607c0bb73047814c4
updatable=0
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:44
create-version=1
source=SELECT\n  `temi`.`name_temi` AS `name_temi`,\n  COUNT(`jyrnal_izychenia`.`id_users`) AS `colvo_user`\nFROM (`temi`\n  LEFT JOIN `jyrnal_izychenia`\n    ON ((`jyrnal_izychenia`.`id_temi` = `temi`.`id_temi`)))\nGROUP BY `temi`.`name_temi`
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`temi`.`name_temi` AS `name_temi`,count(`mathematical_analysis`.`jyrnal_izychenia`.`id_users`) AS `colvo_user` from (`mathematical_analysis`.`temi` left join `mathematical_analysis`.`jyrnal_izychenia` on((`mathematical_analysis`.`jyrnal_izychenia`.`id_temi` = `mathematical_analysis`.`temi`.`id_temi`))) group by `mathematical_analysis`.`temi`.`name_temi`
