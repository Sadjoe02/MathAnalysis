TYPE=VIEW
query=select `mathematical_analysis`.`tests`.`name_test` AS `name_test`,concat(`mathematical_analysis`.`users`.`familia`,\' \',`mathematical_analysis`.`users`.`name`,\' \',`mathematical_analysis`.`users`.`otchestvo`) AS `FIO`,`mathematical_analysis`.`popitki`.`id_users` AS `id_users`,count(`mathematical_analysis`.`popitki`.`id_popitka`) AS `kolvo_popitok` from ((`mathematical_analysis`.`tests` join `mathematical_analysis`.`popitki` on((`mathematical_analysis`.`popitki`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`))) join `mathematical_analysis`.`users` on((`mathematical_analysis`.`popitki`.`id_users` = `mathematical_analysis`.`users`.`id_users`))) group by `mathematical_analysis`.`tests`.`name_test`,`mathematical_analysis`.`users`.`otchestvo`,`mathematical_analysis`.`users`.`name`,`mathematical_analysis`.`users`.`familia`,`mathematical_analysis`.`popitki`.`id_users`
md5=5f804e53a1476761d69e671d0ae12639
updatable=0
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-03-27 11:15:44
create-version=1
source=SELECT\n  `tests`.`name_test` AS `name_test`,\n  CONCAT(`users`.`familia`, \' \', `users`.`name`, \' \', `users`.`otchestvo`) AS `FIO`,\n  `popitki`.`id_users` AS `id_users`,\n  COUNT(`popitki`.`id_popitka`) AS `kolvo_popitok`\nFROM ((`tests`\n  JOIN `popitki`\n    ON ((`popitki`.`id_tests` = `tests`.`id_test`)))\n  JOIN `users`\n    ON ((`popitki`.`id_users` = `users`.`id_users`)))\nGROUP BY `tests`.`name_test`,\n         `users`.`otchestvo`,\n         `users`.`name`,\n         `users`.`familia`,\n         `popitki`.`id_users`
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `mathematical_analysis`.`tests`.`name_test` AS `name_test`,concat(`mathematical_analysis`.`users`.`familia`,\' \',`mathematical_analysis`.`users`.`name`,\' \',`mathematical_analysis`.`users`.`otchestvo`) AS `FIO`,`mathematical_analysis`.`popitki`.`id_users` AS `id_users`,count(`mathematical_analysis`.`popitki`.`id_popitka`) AS `kolvo_popitok` from ((`mathematical_analysis`.`tests` join `mathematical_analysis`.`popitki` on((`mathematical_analysis`.`popitki`.`id_tests` = `mathematical_analysis`.`tests`.`id_test`))) join `mathematical_analysis`.`users` on((`mathematical_analysis`.`popitki`.`id_users` = `mathematical_analysis`.`users`.`id_users`))) group by `mathematical_analysis`.`tests`.`name_test`,`mathematical_analysis`.`users`.`otchestvo`,`mathematical_analysis`.`users`.`name`,`mathematical_analysis`.`users`.`familia`,`mathematical_analysis`.`popitki`.`id_users`
