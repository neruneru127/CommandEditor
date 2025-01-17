﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEditor
{
    public class ItemData
    {
        public enum ItemType
        {
            Normal,
            Tool,
            LeatherArmor,
            EnchantBook,
            Potion,
            Book,
            PlayerHead,
            FireWork,
            ArmorStand,
            SpawnEgg,
            Map,
            Block
        }

        public struct ItemBaseData
        {
            public string name;
            public string description;
            public ItemType itemType;

            /// <summary>
            /// ItemDataListの中身を再生成する
            /// 
            /// ブロックのデータも入れないといけない為、生成用のメソッドを作成
            /// 何かいい方法はない？
            /// </summary>
            public static void refresh()
            {
                ItemDataList.AddRange(ItemBaseList);
                foreach (var block in BlockData.BlockBaseList)
                {
                    if (block.canInventory)
                    {
                        ItemDataList.Add(new ItemBaseData() { name = block.name, description = block.description });
                    }
                }

            }
        }

        public static readonly ItemBaseData[] ItemBaseList =
        {
            new ItemBaseData{name = "iron_sword",                description = ""},
            new ItemBaseData{name = "iron_shovel",               description = ""},
            new ItemBaseData{name = "iron_pickaxe",              description = ""},
            new ItemBaseData{name = "iron_axe",                  description = ""},
            new ItemBaseData{name = "iron_hoe",                  description = ""},
            new ItemBaseData{name = "wooden_sword",              description = ""},
            new ItemBaseData{name = "wooden_shovel",             description = ""},
            new ItemBaseData{name = "wooden_pickaxe",            description = ""},
            new ItemBaseData{name = "wooden_axe",                description = ""},
            new ItemBaseData{name = "wooden_hoe",                description = ""},
            new ItemBaseData{name = "stone_sword",               description = ""},
            new ItemBaseData{name = "stone_shovel",              description = ""},
            new ItemBaseData{name = "stone_pickaxe",             description = ""},
            new ItemBaseData{name = "stone_axe",                 description = ""},
            new ItemBaseData{name = "stone_hoe",                 description = ""},
            new ItemBaseData{name = "diamond_sword",             description = ""},
            new ItemBaseData{name = "diamond_shovel",            description = ""},
            new ItemBaseData{name = "diamond_pickaxe",           description = ""},
            new ItemBaseData{name = "diamond_axe",               description = ""},
            new ItemBaseData{name = "diamond_hoe",               description = ""},
            new ItemBaseData{name = "golden_sword",              description = ""},
            new ItemBaseData{name = "golden_shovel",             description = ""},
            new ItemBaseData{name = "golden_pickaxe",            description = ""},
            new ItemBaseData{name = "golden_axe",                description = ""},
            new ItemBaseData{name = "golden_hoe",                description = ""},
            new ItemBaseData{name = "leather_helmet",            description = ""},
            new ItemBaseData{name = "leather_chestplate",        description = ""},
            new ItemBaseData{name = "leather_leggings",          description = ""},
            new ItemBaseData{name = "leather_boots",             description = ""},
            new ItemBaseData{name = "chainmail_helmet",          description = ""},
            new ItemBaseData{name = "chainmail_chestplate",      description = ""},
            new ItemBaseData{name = "chainmail_leggings",        description = ""},
            new ItemBaseData{name = "chainmail_boots",           description = ""},
            new ItemBaseData{name = "iron_helmet",               description = ""},
            new ItemBaseData{name = "iron_chestplate",           description = ""},
            new ItemBaseData{name = "iron_leggings",             description = ""},
            new ItemBaseData{name = "iron_boots",                description = ""},
            new ItemBaseData{name = "diamond_helmet",            description = ""},
            new ItemBaseData{name = "diamond_chestplate",        description = ""},
            new ItemBaseData{name = "diamond_leggings",          description = ""},
            new ItemBaseData{name = "diamond_boots",             description = ""},
            new ItemBaseData{name = "golden_helmet",             description = ""},
            new ItemBaseData{name = "golden_chestplate",         description = ""},
            new ItemBaseData{name = "golden_leggings",           description = ""},
            new ItemBaseData{name = "golden_boots",              description = ""},
            new ItemBaseData{name = "turtle_helmet",             description = ""},
            new ItemBaseData{name = "scute",                     description = ""},
            new ItemBaseData{name = "flint_and_steel",           description = ""},
            new ItemBaseData{name = "bow",                       description = ""},
            new ItemBaseData{name = "arrow",                     description = ""},
            new ItemBaseData{name = "apple",                     description = ""},
            new ItemBaseData{name = "coal",                      description = ""},
            new ItemBaseData{name = "charcoal",                  description = ""},
            new ItemBaseData{name = "diamond",                   description = ""},
            new ItemBaseData{name = "iron_ingot",                description = ""},
            new ItemBaseData{name = "gold_ingot",                description = ""},
            new ItemBaseData{name = "stick",                     description = ""},
            new ItemBaseData{name = "bowl",                      description = ""},
            new ItemBaseData{name = "mushroom_stew",             description = ""},
            new ItemBaseData{name = "string",                    description = ""},
            new ItemBaseData{name = "feather",                   description = ""},
            new ItemBaseData{name = "gunpowder",                 description = ""},
            new ItemBaseData{name = "wheat_seeds",               description = ""},
            new ItemBaseData{name = "wheat",                     description = ""},
            new ItemBaseData{name = "bread",                     description = ""},
            new ItemBaseData{name = "flint",                     description = ""},
            new ItemBaseData{name = "porkchop",                  description = ""},
            new ItemBaseData{name = "cooked_porkchop",           description = ""},
            new ItemBaseData{name = "painting",                  description = ""},
            new ItemBaseData{name = "golden_apple",              description = ""},
            new ItemBaseData{name = "enchanted_golden_apple",    description = ""},
            new ItemBaseData{name = "bucket",                    description = ""},
            new ItemBaseData{name = "water_bucket",              description = ""},
            new ItemBaseData{name = "lava_bucket",               description = ""},
            new ItemBaseData{name = "milk_bucket",               description = ""},
            new ItemBaseData{name = "minecart",                  description = ""},
            new ItemBaseData{name = "saddle",                    description = ""},
            new ItemBaseData{name = "redstone",                  description = ""},
            new ItemBaseData{name = "snowball",                  description = ""},
            new ItemBaseData{name = "oak_boat",                  description = ""},
            new ItemBaseData{name = "spruce_boat",               description = ""},
            new ItemBaseData{name = "birch_boat",                description = ""},
            new ItemBaseData{name = "jungle_boat",               description = ""},
            new ItemBaseData{name = "acacia_boat",               description = ""},
            new ItemBaseData{name = "dark_oak_boat",             description = ""},
            new ItemBaseData{name = "leather",                   description = ""},
            new ItemBaseData{name = "pufferfish_bucket",         description = ""},
            new ItemBaseData{name = "salmon_bucket",             description = ""},
            new ItemBaseData{name = "cod_bucket",                description = ""},
            new ItemBaseData{name = "tropical_fish_bucket",      description = ""},
            new ItemBaseData{name = "brick",                     description = ""},
            new ItemBaseData{name = "clay_ball",                 description = ""},
            new ItemBaseData{name = "sugar_cane",                description = ""},
            new ItemBaseData{name = "kelp",                      description = ""},
            new ItemBaseData{name = "paper",                     description = ""},
            new ItemBaseData{name = "book",                      description = ""},
            new ItemBaseData{name = "slime_ball",                description = ""},
            new ItemBaseData{name = "chest_minecart",            description = ""},
            new ItemBaseData{name = "furnace_minecart",          description = ""},
            new ItemBaseData{name = "tnt_minecart",              description = ""},
            new ItemBaseData{name = "hopper_minecart",           description = ""},
            new ItemBaseData{name = "command_block_minecart",    description = ""},
            new ItemBaseData{name = "egg",                       description = ""},
            new ItemBaseData{name = "compass",                   description = ""},
            new ItemBaseData{name = "fishing_rod",               description = ""},
            new ItemBaseData{name = "clock",                     description = ""},
            new ItemBaseData{name = "glowstone_dust",            description = ""},
            new ItemBaseData{name = "cod",                       description = ""},
            new ItemBaseData{name = "salmon",                    description = ""},
            new ItemBaseData{name = "tropical_fish",             description = ""},
            new ItemBaseData{name = "pufferfish",                description = ""},
            new ItemBaseData{name = "cooked_cod",                description = ""},
            new ItemBaseData{name = "cooked_salmon",             description = ""},
            new ItemBaseData{name = "ink_sac",                   description = ""},
            new ItemBaseData{name = "red_dye‌",                   description = ""},
            new ItemBaseData{name = "green_dye‌",                 description = ""},
            new ItemBaseData{name = "cocoa_beans",               description = ""},
            new ItemBaseData{name = "lapis_lazuli",              description = ""},
            new ItemBaseData{name = "purple_dye",                description = ""},
            new ItemBaseData{name = "cyan_dye",                  description = ""},
            new ItemBaseData{name = "light_gray_dye",            description = ""},
            new ItemBaseData{name = "gray_dye",                  description = ""},
            new ItemBaseData{name = "pink_dye",                  description = ""},
            new ItemBaseData{name = "lime_dye",                  description = ""},
            new ItemBaseData{name = "yellow_dye‌",                description = ""},
            new ItemBaseData{name = "light_blue_dye",            description = ""},
            new ItemBaseData{name = "magenta_dye",               description = ""},
            new ItemBaseData{name = "orange_dye",                description = ""},
            new ItemBaseData{name = "bone_meal",                 description = ""},
            new ItemBaseData{name = "blue_dye‌",                  description = ""},
            new ItemBaseData{name = "brown_dye‌",                 description = ""},
            new ItemBaseData{name = "black_dye‌",                 description = ""},
            new ItemBaseData{name = "white_dye‌",                 description = ""},
            new ItemBaseData{name = "bone",                      description = ""},
            new ItemBaseData{name = "sugar",                     description = ""},
            new ItemBaseData{name = "cookie",                    description = ""},
            new ItemBaseData{name = "shears",                    description = ""},
            new ItemBaseData{name = "melon_slice",               description = ""},
            new ItemBaseData{name = "dried_kelp",                description = ""},
            new ItemBaseData{name = "pumpkin_seeds",             description = ""},
            new ItemBaseData{name = "melon_seeds",               description = ""},
            new ItemBaseData{name = "beef",                      description = ""},
            new ItemBaseData{name = "cooked_beef",               description = ""},
            new ItemBaseData{name = "chicken",                   description = ""},
            new ItemBaseData{name = "cooked_chicken",            description = ""},
            new ItemBaseData{name = "rotten_flesh",              description = ""},
            new ItemBaseData{name = "ender_pearl",               description = ""},
            new ItemBaseData{name = "blaze_rod",                 description = ""},
            new ItemBaseData{name = "ghast_tear",                description = ""},
            new ItemBaseData{name = "gold_nugget",               description = ""},
            new ItemBaseData{name = "nether_wart",               description = ""},
            new ItemBaseData{name = "glass_bottle",              description = ""},
            new ItemBaseData{name = "potion",                    description = ""},
            new ItemBaseData{name = "splash_potion",             description = ""},
            new ItemBaseData{name = "lingering_potion",          description = ""},
            new ItemBaseData{name = "tipped_arrow",              description = ""},
            new ItemBaseData{name = "spectral_arrow",            description = ""},
            new ItemBaseData{name = "spider_eye",                description = ""},
            new ItemBaseData{name = "fermented_spider_eye",      description = ""},
            new ItemBaseData{name = "blaze_powder",              description = ""},
            new ItemBaseData{name = "magma_cream",               description = ""},
            new ItemBaseData{name = "ender_eye",                 description = ""},
            new ItemBaseData{name = "glistering_melon_slice",    description = ""},
            new ItemBaseData{name = "debug_stick",               description = ""},
            new ItemBaseData{name = "bat_spawn_egg",             description = ""},
            new ItemBaseData{name = "blaze_spawn_egg",           description = ""},
            new ItemBaseData{name = "cat_spawn_egg‌",             description = ""},
            new ItemBaseData{name = "cave_spider_spawn_egg",     description = ""},
            new ItemBaseData{name = "chicken_spawn_egg",         description = ""},
            new ItemBaseData{name = "cod_spawn_egg",             description = ""},
            new ItemBaseData{name = "cow_spawn_egg",             description = ""},
            new ItemBaseData{name = "creeper_spawn_egg",         description = ""},
            new ItemBaseData{name = "dolphin_spawn_egg",         description = ""},
            new ItemBaseData{name = "donkey_spawn_egg",          description = ""},
            new ItemBaseData{name = "drowned_spawn_egg",         description = ""},
            new ItemBaseData{name = "elder_guardian_spawn_egg",  description = ""},
            new ItemBaseData{name = "enderman_spawn_egg",        description = ""},
            new ItemBaseData{name = "endermite_spawn_egg",       description = ""},
            new ItemBaseData{name = "evoker_spawn_egg",          description = ""},
            new ItemBaseData{name = "ghast_spawn_egg",           description = ""},
            new ItemBaseData{name = "guardian_spawn_egg",        description = ""},
            new ItemBaseData{name = "horse_spawn_egg",           description = ""},
            new ItemBaseData{name = "husk_spawn_egg",            description = ""},
            new ItemBaseData{name = "illager_beast_spawn_egg‌",   description = ""},
            new ItemBaseData{name = "llama_spawn_egg",           description = ""},
            new ItemBaseData{name = "magma_cube_spawn_egg",      description = ""},
            new ItemBaseData{name = "mooshroom_spawn_egg",       description = ""},
            new ItemBaseData{name = "mule_spawn_egg",            description = ""},
            new ItemBaseData{name = "ocelot_spawn_egg",          description = ""},
            new ItemBaseData{name = "panda_spawn_egg‌",           description = ""},
            new ItemBaseData{name = "parrot_spawn_egg",          description = ""},
            new ItemBaseData{name = "phantom _spawn_egg",        description = ""},
            new ItemBaseData{name = "pig_spawn_egg",             description = ""},
            new ItemBaseData{name = "pillager_spawn_egg‌",        description = ""},
            new ItemBaseData{name = "polar_bear_spawn_egg",      description = ""},
            new ItemBaseData{name = "pufferfish_spawn_egg",      description = ""},
            new ItemBaseData{name = "rabbit_spawn_egg",          description = ""},
            new ItemBaseData{name = "salmon_spawn_egg",          description = ""},
            new ItemBaseData{name = "sheep_spawn_egg",           description = ""},
            new ItemBaseData{name = "shulker_spawn_egg",         description = ""},
            new ItemBaseData{name = "silverfish_spawn_egg",      description = ""},
            new ItemBaseData{name = "skeleton_spawn_egg",        description = ""},
            new ItemBaseData{name = "skeleton_horse_spawn_egg",  description = ""},
            new ItemBaseData{name = "slime_spawn_egg",           description = ""},
            new ItemBaseData{name = "spider_spawn_egg",          description = ""},
            new ItemBaseData{name = "squid_spawn_egg",           description = ""},
            new ItemBaseData{name = "stray_spawn_egg",           description = ""},
            new ItemBaseData{name = "tropical_fish_spawn_egg",   description = ""},
            new ItemBaseData{name = "turtle_spawn_egg",          description = ""},
            new ItemBaseData{name = "vex_spawn_egg",             description = ""},
            new ItemBaseData{name = "villager_spawn_egg",        description = ""},
            new ItemBaseData{name = "vindicator_spawn_egg",      description = ""},
            new ItemBaseData{name = "witch_spawn_egg",           description = ""},
            new ItemBaseData{name = "wither_skeleton_spawn_egg", description = ""},
            new ItemBaseData{name = "wolf_spawn_egg",            description = ""},
            new ItemBaseData{name = "zombie_spawn_egg",          description = ""},
            new ItemBaseData{name = "zombie_horse_spawn_egg",    description = ""},
            new ItemBaseData{name = "zombie_pigman_spawn_egg",   description = ""},
            new ItemBaseData{name = "zombie_villager_spawn_egg", description = ""},
            new ItemBaseData{name = "experience_bottle",         description = ""},
            new ItemBaseData{name = "fire_charge",               description = ""},
            new ItemBaseData{name = "writable_book",             description = ""},
            new ItemBaseData{name = "written_book",              description = ""},
            new ItemBaseData{name = "emerald",                   description = ""},
            new ItemBaseData{name = "item_frame",                description = ""},
            new ItemBaseData{name = "carrot",                    description = ""},
            new ItemBaseData{name = "potato",                    description = ""},
            new ItemBaseData{name = "baked_potato",              description = ""},
            new ItemBaseData{name = "poisonous_potato",          description = ""},
            new ItemBaseData{name = "map",                       description = ""},
            new ItemBaseData{name = "filled_map",                description = ""},
            new ItemBaseData{name = "golden_carrot",             description = ""},
            new ItemBaseData{name = "carrot_on_a_stick",         description = ""},
            new ItemBaseData{name = "nether_star",               description = ""},
            new ItemBaseData{name = "pumpkin_pie",               description = ""},
            new ItemBaseData{name = "firework_rocket",           description = ""},
            new ItemBaseData{name = "firework_star",             description = ""},
            new ItemBaseData{name = "enchanted_book",            description = ""},
            new ItemBaseData{name = "nether_brick",              description = ""},
            new ItemBaseData{name = "quartz",                    description = ""},
            new ItemBaseData{name = "prismarine_shard",          description = ""},
            new ItemBaseData{name = "prismarine_crystals",       description = ""},
            new ItemBaseData{name = "rabbit",                    description = ""},
            new ItemBaseData{name = "cooked_rabbit",             description = ""},
            new ItemBaseData{name = "rabbit_stew",               description = ""},
            new ItemBaseData{name = "rabbit_foot",               description = ""},
            new ItemBaseData{name = "rabbit_hide",               description = ""},
            new ItemBaseData{name = "armor_stand",               description = ""},
            new ItemBaseData{name = "iron_horse_armor",          description = ""},
            new ItemBaseData{name = "golden_horse_armor",        description = ""},
            new ItemBaseData{name = "diamond_horse_armor",       description = ""},
            new ItemBaseData{name = "lead",                      description = ""},
            new ItemBaseData{name = "name_tag",                  description = ""},
            new ItemBaseData{name = "mutton",                    description = ""},
            new ItemBaseData{name = "cooked_mutton",             description = ""},
            new ItemBaseData{name = "end_crystal",               description = ""},
            new ItemBaseData{name = "chorus_fruit",              description = ""},
            new ItemBaseData{name = "popped_chorus_fruit",       description = ""},
            new ItemBaseData{name = "beetroot",                  description = ""},
            new ItemBaseData{name = "beetroot_seeds",            description = ""},
            new ItemBaseData{name = "beetroot_soup",             description = ""},
            new ItemBaseData{name = "dragon_breath",             description = ""},
            new ItemBaseData{name = "shield",                    description = ""},
            new ItemBaseData{name = "elytra",                    description = ""},
            new ItemBaseData{name = "totem_of_undying",          description = ""},
            new ItemBaseData{name = "shulker_shell",             description = ""},
            new ItemBaseData{name = "iron_nugget",               description = ""},
            new ItemBaseData{name = "trident",                   description = ""},
            new ItemBaseData{name = "phantom_membrane",          description = ""},
            new ItemBaseData{name = "nautilus_shell",            description = ""},
            new ItemBaseData{name = "heart_of_the_sea",          description = ""},
            new ItemBaseData{name = "music_disc_13",             description = ""},
            new ItemBaseData{name = "music_disc_cat",            description = ""},
            new ItemBaseData{name = "music_disc_blocks",         description = ""},
            new ItemBaseData{name = "music_disc_chirp",          description = ""},
            new ItemBaseData{name = "music_disc_far",            description = ""},
            new ItemBaseData{name = "music_disc_mall",           description = ""},
            new ItemBaseData{name = "music_disc_mellohi",        description = ""},
            new ItemBaseData{name = "music_disc_stal",           description = ""},
            new ItemBaseData{name = "music_disc_strad",          description = ""},
            new ItemBaseData{name = "music_disc_ward",           description = ""},
            new ItemBaseData{name = "music_disc_11",             description = ""},
            new ItemBaseData{name = "music_disc_wait",           description = ""},
            new ItemBaseData{name = "crossbow‌",                  description = ""},
            new ItemBaseData{name = "flower_banner_pattern‌",     description = ""},
            new ItemBaseData{name = "creeper_banner_pattern‌",    description = ""},
            new ItemBaseData{name = "skull_banner_pattern‌",      description = ""},
            new ItemBaseData{name = "mojang_banner_pattern‌",     description = ""},
            new ItemBaseData{name = "sweet_berries‌",             description = ""},
            new ItemBaseData{name = "suspicious_stew‌",           description = ""}
        };

        public static List<ItemBaseData> ItemDataList = new List<ItemBaseData>();

        private int itemTypeIndex = 0;

        public void SetItemTypeIndex(int index)
        {
            itemTypeIndex = index;
        }

        public int GetItemTypeIndex()
        {
            return itemTypeIndex;
        }

        public override string ToString()
        {
            return ItemBaseList[itemTypeIndex].name;
        }
    }
}
