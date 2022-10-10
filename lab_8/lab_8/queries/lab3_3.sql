use var5sql

SELECT mounting.place, F107.place AS tchk_place FROM mounting LEFT JOIN  F107 ON F107.place = mounting.place where F107.place is null
