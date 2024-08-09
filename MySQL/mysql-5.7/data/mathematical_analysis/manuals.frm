TYPE=VIEW
query=select `mathematical_analysis`.`image_manual`.`image` AS `image`,`mathematical_analysis`.`image_manual`.`image_number` AS `image_number`,`mathematical_analysis`.`manual`.`text_manual` AS `text_manual` from (`mathematical_analysis`.`image_manual` join `mathematical_analysis`.`manual` on((`mathematical_analysis`.`image_manual`.`id_manual` = `mathematical_analysis`.`manual`.`id_manual`)))
md5=afcc63e9cf42e48f653640558497874f
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:45
create-version=1
source=SELECT\n  `image_manual`.`image` AS `image`,\n  `image_manual`.`image_number` AS `image_number`,\n  `manual`.`text_manual` AS `text_manual`\nFROM (`image_manual`\n  JOIN `manual`\n    ON ((`image_manual`.`id_manual` = `manual`.`id_manual`)))
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`image_manual`.`image` AS `image`,`mathematical_analysis`.`image_manual`.`image_number` AS `image_number`,`mathematical_analysis`.`manual`.`text_manual` AS `text_manual` from (`mathematical_analysis`.`image_manual` join `mathematical_analysis`.`manual` on((`mathematical_analysis`.`image_manual`.`id_manual` = `mathematical_analysis`.`manual`.`id_manual`)))
